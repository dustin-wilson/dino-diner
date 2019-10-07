/* SteakosaurusBurger.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing Steakosaurus Burger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        //Represents if bun should be added
        private bool bun = true;
        //Represents if pickle should be added
        private bool pickle = true;
        //Represents if ketchup should be added
        private bool ketchup = true;
        //Represents if mustard should be added
        private bool mustard = true;

        /// <summary>
        /// Sets bun property to false
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Sets pickle property to false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Sets ketchup property to false
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Sets mustard property to false
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Lists ingredients in the item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs an instance of class
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
