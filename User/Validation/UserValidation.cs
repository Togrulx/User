using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using User.Models;

namespace User.Validation
{
    public class UserValidation : UserModel
    {
        public UserValidation(string name, string surName, string email, string password, int? id = null) : base(name, surName, email, password, id)
        {
        }

        public static bool IsValidName(string name)
        {

            if (name.Length <= 30 && name.Length >= 3)
            {
                return true;
            }

            Console.WriteLine("Duzgun deyer daxil edin");
            return false;
        }

        public static bool IsValidSurname(string surname)
        {
            if (surname.Length <= 20 && surname.Length >= 5)
            {
                return true;
            }

            Console.WriteLine("Duzgun deyer daxil edin");
            return false;

        }

        public static bool IsValidEmail(string email)
        {

            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidPassword(string password,string repassword)
        {
            if (password==repassword)
            {
                return true;
            }
            return false;

        }


    }
}

