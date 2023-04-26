using System;
using User.Models;
using User.Validation;
using Users.Repositories;

namespace User.Authhentication
{
    public class Authhentication
    {
        public static void Register()
        {
            string name = GetName();
            string surname = GetSurname();
            string email = GetEmail();
            string password = GetPassword();

            if (UserValidation.IsValidName(name) & UserValidation.IsValidSurname(surname) & UserValidation.IsValidEmail(email))
            {

                UserModel userModel = UserRepository.AddUser(name, surname, email, password);
                Console.WriteLine($"User yarandi{userModel.GetInfo()}");

            }
        }


        public static string GetName()
        {
            Console.WriteLine("Ad Daxil edin");
            string name = Console.ReadLine();

            while (!UserValidation.IsValidName(name))
            {
                name = Console.ReadLine();

            }
            return name;

        }

        public static string GetSurname()
        {
            Console.WriteLine("Soyad Daxil edin");
            string surname = Console.ReadLine();

            while (!UserValidation.IsValidSurname(surname))
            {
                surname = Console.ReadLine();

            }
            return surname;

        }

        public static string GetEmail()
        {
            Console.WriteLine("Email daxil edin");
            string email = Console.ReadLine();

            while (!UserValidation.IsValidEmail(email))
            {
                email = Console.ReadLine();
            }
            return email;
        }

        public static string GetPassword()
        {
            Console.WriteLine("Password daxil edin");
            string password = Console.ReadLine();
            string repassword = Console.ReadLine();

            while (!UserValidation.IsValidPassword(password, repassword))
            {
                password = Console.ReadLine();
            }
            return password;
        }
    }
}

