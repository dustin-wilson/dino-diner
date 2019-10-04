using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {   // Private backing for Size
        private Size size;

        /// <summary>
        /// Property which returns and set flavor
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }
        
        /// <summary>
        /// Property to get and set size as well as change
        /// Calories and Price with it
        /// </summary>
        public override Size Size
        {
            get { return size; }

            set
            {
                size = value;

                switch (size)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Makes the list of ingredients immutable
        /// Returns the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingredients = new List<string>();

                ingredients.Add("Water");
                ingredients.Add("Cane Sugar");
                ingredients.Add("Natural Flavors");

                return ingredients;
            }
        }
        /// <summary>
        /// Public constructor for Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Calories = 112;
            this.Price = 1.5;
        }
    }
}
