using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
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

                ingredients.Add("Cheese Product");
                ingredients.Add("Breading");
                ingredients.Add("Vegetable Oil");

                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for Mezzore Sticks
        /// </summary>
        public MezzorellaSticks()
        {
            Price = .99;
            Calories = 540;
        }
    }
}
