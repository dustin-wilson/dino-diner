using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }

        public uint Calories { get; set; }
        
        private uint numberNuggets;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };

                for(int i = 0; i < numberNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
            this.numberNuggets = 6;
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.numberNuggets++;
        }
    }
}
