﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class representing Pterodactyl Wings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Gets and Sets Price property
        /// </summary>
        public double Price { get; set; }
        
        /// <summary>
        /// Gets and Sets Calories property
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Lists the ingredients in the item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new instance of the item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
