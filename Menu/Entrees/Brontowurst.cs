/* Brotowurst.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the Brontowurt entree
    /// </summary>
    public class Brontowurst : Entree
    {
        //Does customer want the bun
        private bool bun = true;
        //Does customer want peppers
        private bool peppers = true;
        //Does customer want onions
        private bool onions = true;

        /// <summary>
        /// List the ingredients in the item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructors a new instance of Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Sets bun property to false so won't appear on ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets peppers property to false so won't appear on ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets onion property to false so won't appear on ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns any special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }
    }
}
