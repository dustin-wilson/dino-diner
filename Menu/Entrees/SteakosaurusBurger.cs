﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class representing Steakosaurus Burger
    /// </summary>
    public class SteakosaurusBurger
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
        public List<string> Ingredients
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
        /// Gets and sets the Price property
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets Calories property
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Constructs an instance of class
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
    }
}
