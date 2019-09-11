using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public void HoldDressing()
        {
            dressing = false;
        }

        public void HoldLettuce()
        {
            lettuce = false;
        }

        public void HoldCheese()
        {
            cheese = false;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>("Flour Tortilla", "Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        private double Price { get; set; }

        private uint Calorie { get; set; }

        public VelociWrap()
        {
            Price = 6.86;
            Calorie = 356;
        }
    }
}
