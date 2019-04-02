using System.Collections.Generic;
using Domain;

namespace DAL.EF
{
    public interface IUserRepository
    {
        IEnumerable<User> readUsers();
        User readUser(int id);
        User createUser(User user);
        void updateUser(User user);
        void deleteUser(int id);
        Place getPlace(int postalcode, string name);
        Place createPlace(int postalcode, string name);
    }
}