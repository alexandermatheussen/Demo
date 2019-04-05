using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IUserManager
    {
        IEnumerable<User> getUsers();
        User getUser(int id);
        void addUser(User user);
        void changeUser(User user);
        void removeUser(int id);
        Place getPlace(int postalcode, string name);
        Address getAddress(int number, string street, int postalcode, string name);
    }
}