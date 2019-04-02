using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BL.Managers;
using DAL;
using DAL.EF;
using Domain;

namespace BL
{
    public class UserManager : IUserManager
    {
        private IUserRepository repo;

        public UserManager()
        {
            repo = new UserRepository();
        }
        
        public UserManager(UnitOfWorkManager unitOfWorkManager)
        {
            if (unitOfWorkManager == null)
            {
                throw new ArgumentException("unitOfWorkManager");
            }
            repo = new UserRepository(unitOfWorkManager.UnitOfWork);
        }


        public IEnumerable<User> getUsers()
        {
            return repo.readUsers();
        }

        public User getUser(int id)
        {
            return repo.readUser(id);
        }

        public void addUser(User user)
        {
            repo.createUser(user);
        }

        public void changeUser(User user)
        {
            Validator.ValidateObject(user, new ValidationContext(user));
            repo.updateUser(user);
        }

        public void removeUser(int id)
        {
            repo.deleteUser(id);
        }

        public Place getPlace(int postalcode, string name)
        {
            return repo.getPlace(postalcode, name);
        }
    }
}