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
            
            Console.WriteLine("Enter gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter birthdate");
            var birthdate = DateTime.Parse(Console.ReadLine());  // TODO redo it

            Console.WriteLine("Enter weight");
            var weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
