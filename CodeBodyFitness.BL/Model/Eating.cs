using System;
using System.Collections.Generic;
using System.Data;


namespace CodeBodyFitness.BL.Model
{
    [Serializable]

    /// <summary>
    /// lunch time
    /// </summary>
    public class Eating
    {
        public DateTime Moment { get; }

        public Dictionary<Food, double> Foods { get; }

        public User User { get; }

        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Not null for user", nameof(user));
            DateTime now = DateTime.UtcNow;
            Moment = now;
            Foods = new Dictionary<Food, double>();
        }

        public void Add(Food food, double weight)
        {
            var product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));

            if(product == null) Foods.Add(food, weight);
            else Foods[product] += weight;
        }
    }
}
