using System;

namespace CodeBodyFitness.BL.Model
{
    [Serializable]
    public class User
    {
        #region Atributes
        /// <summary>
        /// User
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Birth date
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
        #endregion

        /// <summary>
        /// New user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region condtions for vars
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name is not empty", nameof(name));
            if (gender == null)
                throw new ArgumentNullException("Gender is not null", nameof(gender));
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate>=DateTime.Now)
                throw new ArgumentException("Date is not valid", nameof(birthDate));
            if (weight <= 0.0)
            {
                throw new ArgumentException("Weight i not less 0", nameof(weight));
            }

            if (height <= 0.0)
                throw new ArgumentException("Height is not less 0", nameof(height));
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty or null", nameof(name));
            }

            Name = name;
        }

        public override string? ToString()
        {
            return Name+" "+Age;
        }
    }
}
