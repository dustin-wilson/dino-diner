/* Sodasaurus.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {   // Private backing for Size
        private Size size;
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Property which returns and set flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }
        
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

                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return this.Size.ToString() + " " + this.Flavor.ToString() + " Sodasaurus";
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
