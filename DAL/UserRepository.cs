using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;

namespace DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly DemoDbContext ctx;


        public UserRepository()
        {
            ctx = new DemoDbContext();
        }
        
        public UserRepository(UnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            ctx = unitOfWork.Context;
        }


        public IEnumerable<User> readUsers()
        {
            return ctx.users.AsEnumerable();
        }

        public User readUser(int id)
        {
            return ctx.users.Find(id);
        }

        public User createUser(User user)
        {
            ctx.users.Add(user);
            ctx.SaveChanges();

            return user;
        }

        public void updateUser(User user)
        {
            ctx.users.Update(user);
            ctx.SaveChanges();
        }

        public void deleteUser(int id)
        {
            User user = ctx.users.Find(id);
            ctx.users.Remove(user);
            ctx.SaveChanges();
        }

        public Address getAddress(int number, string street, int postalcode, string name)
        {
            try
            {
                Place place = getPlace(postalcode, name);
                Address address = ctx.addresses.First(a => a.street.Equals(street) && a.number == number && a.place.Equals(place));
                
                return address;
            }
            catch (InvalidOperationException e)
            {
                return createAddress(number, street, postalcode, name);
            }
        }

        public Address createAddress(int number, string street, int postalcode, string name)
        {
            Place place = getPlace(postalcode, name);
            Address newAddress = new Address()
            {
                number = number,
                street = street,
                place = place
            };
            ctx.addresses.Add(newAddress);
            ctx.SaveChanges();
            return newAddress;
        }

        public Place getPlace(int postalcode, string name)
        {
            try
            {
                Place place = ctx.places.First(p => p.postalCode == postalcode && p.name.Equals(name));
                return place;
            }
            catch (InvalidOperationException e)
            {
                return createPlace(postalcode, name);
            }
        }

        public Place createPlace(int postalcode, string name)
        {
            Place newPlace = new Place()
            {
                name = name,
                postalCode = postalcode
            };
            ctx.places.Add(newPlace);
            ctx.SaveChanges();
            return newPlace;
        }
    }
}