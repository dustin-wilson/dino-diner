using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the VelociWrap item
    /// </summary>
    public class VelociWrap
    {
        //Represents if dressing should be added
        private bool dressing = true;
        //Represents if lettuce should be added
        private bool lettuce = true;
        //Represents if cheese should be added
        private bool cheese = true;

        /// <summary>
        /// Sets dressing field to false
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Sets lettuce field to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets cheese field to false
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Lists the ingredients in the item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets and sets the Price property
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Calories property
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Constructs a new instance of the item
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;  
            this.Calories = 356;
        }
    }
}
