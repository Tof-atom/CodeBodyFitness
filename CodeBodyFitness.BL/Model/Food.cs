using System;


namespace CodeBodyFitness.BL.Model
{
    [Serializable]

    public class Food
    {
        public String Name { get; }

        /// <summary>
        /// Proteins
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// fats
        /// </summary>
        public double Fats { get; }

        public double Carbohydrates { get; }
        /// <summary>
        /// Calories per 100gramms
        /// </summary>
        public double Calories { get; }

        private double CaloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name): this(name, 0,0,0,0) { }

        public Food(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates/100.0;
            Calories = calories/100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
