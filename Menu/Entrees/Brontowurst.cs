using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the Brontowurt entree
    /// </summary>
    public class Brontowurst
    {
        //Does customer want the bun
        private bool bun = true;
        //Does customer want peppers
        private bool peppers = true;
        //Does customer want onions
        private bool onions = true;

        /// <summary>
        /// Gets or Sets Price property
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets Calories property
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List the ingredients in the item
        /// </summary>
        public List<string> Ingredients
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
        }

        /// <summary>
        /// Sets peppers property to false so won't appear on ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Sets onion property to false so won't appear on ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
