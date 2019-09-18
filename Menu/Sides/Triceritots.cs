﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size;

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

        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;

            ingredients.Add("Potato");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }
    }
}
