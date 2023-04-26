using System;
using User.Models;
using User.Repositories;

namespace Users.Repositories
{
    public class UserRepository : Repository<UserModel>
    {

        private static int _idcounter;

        public static int Idcounter
        {
            get
            {
                _idcounter++;
                return _idcounter;
            }
        }
        public static UserModel AddUser(string name, string surname, string email, string password)
        {
            UserModel userModel = new UserModel(name, surname, email, password,Idcounter);
            _items.Add(userModel);
            return userModel;
            
        }
    }
}

