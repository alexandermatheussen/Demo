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

        /*public Address getAddress(int postalCode)
        {
            Place place1 = ctx.places.First(p => p.postalCode == postalCode);
            return ctx.addresses.First(address => address.place == place1);
        }*/

        public Place getPlace(int postalcode, string name)
        {
            Place place = ctx.places.First(p => p.postalCode == postalcode);
            if (place != null)
            {
                return place;
            }
            else
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