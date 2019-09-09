using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        private List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };

        public List<string> Ingredients { get; }

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59 * 6;
        }

        public void AddNugget()
        {
            Price += .25;
            Calories += 59;
            ingredients.Add("Chicken Nugget");
        }
    }
}
