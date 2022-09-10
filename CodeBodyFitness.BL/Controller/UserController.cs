using CodeBodyFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace CodeBodyFitness.BL.Controller
{

    /// <summary>
    /// User controller
    /// </summary>
    public class UserController
    {
        public User User { get; }


        /// <summary>
        /// Creat a new user
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName, string genderName, DateTime birthDate, double weight, double height)
        {
            // TODO : check condition of user
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDate, weight, height);
        }

        
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.data", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

            }
        }

        /// <summary>
        /// Save user
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.data", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
    }
}
