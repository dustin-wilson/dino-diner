﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        //Holds the size 
        private Size size;

        /// <summary>
        /// Overrides the default size class as declared in Side
        /// Main difference is it also sets the Price and Calories when changed
        /// </summary>
        public override Size Size {
            get { return size; }

            set {
                size = value;

                switch(size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Construncts the Triceritots
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;

            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}
