using System;


namespace CodeBodyFitness.BL.Model
{
    [Serializable]
    /// <summary>
    /// Gender
    /// </summary>
    public class Gender
    {
        public string Name { get;}

        /// <summary>
        /// New gender 
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("no empty name", nameof(name)); 
            Name = name;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
