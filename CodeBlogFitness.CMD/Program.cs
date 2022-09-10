using CodeBodyFitness.BL.Controller;
using CodeBodyFitness.BL.Model;
using System;

namespace CodeBodyFitness.CMD
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welecome to CodeBlogFirtnes");
            
            Console.WriteLine("Please enter user name");
            var name = Console.ReadLine();

            var userController = new UserController(name);

            if (userController.IsNewUser)
            {
                Console.Write("Enter gender: ");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weight = ParseDouble("weight");
                var height = ParseDouble("height");

                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine(userController.CurrentUser);

        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Enter {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Not valid value {name}");
                }
            }
        }
        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Enter birthdate (dd.MM.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not valid birthdate");
                }
            }

            return birthDate;
        }

    }
}
