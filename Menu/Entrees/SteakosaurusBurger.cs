﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public void HoldBun()
        {
            bun = false;
        }

        public void HoldPickle()
        {
            pickle = false;
        }

        public void HoldKetchup()
        {
            ketchup = false;
        }

        public void HoldMustard()
        {
            mustard = false;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        private double Price { get; set; }

        private uint Calorie { get; set; }

        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calorie = 621;
        }
    }
}
