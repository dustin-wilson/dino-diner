/* Fryceritops.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        //Holds the size 
        private Size size;

        /// <summary>
        /// Overrides the default size class as declared in Side
        /// Main difference is it also sets the Price and Calories when changed
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
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
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
                List<string> ingredients = new List<string>();

                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");

                return ingredients;
            }
        } 

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }

        /// <summary>
        /// Override default ToString method
        /// </summary>
        /// <returns>Description of the object</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Friceritops");
        }
    }
}
