using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Drink : IMenuItem
    {
        // Private backing for Ingredients
        protected List<string> ingredients = new List<string>(); 

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Indicates whether ice should be added
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Sets it so ice will not be an added ingredient
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
