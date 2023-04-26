using System;
using User.Models.Base;
using Users.Repositories;

namespace User.Models
{
    public class UserModel : BaseModel
    {

        
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        

        public UserModel(string name, string surName, string email, string password, int? id=null)
        {
            
            Name = name;
            SurName = surName;
            Email = email;
            Password = password;

            if (id!=null)
            {
                Id = id.Value;
            }
            else
            {
                Id = UserRepository.Idcounter;
            }
        }

        public string GetInfo()
        {
            return $"{Id },{Name}, {SurName}";
        }

    }
}

