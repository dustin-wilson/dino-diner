using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        RootBeer,
        Lime,
        Cherry,
        Vanilla,
        Chocolate
    }
    class Sodasaurus : Drink
    {
        private Size size;

        SodasaurusFlavor Flavor { get; set; }

        public override Size Size
        {
            get { return size; }

            set
            {
                size = value;

                switch (size)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
            }
        }

        public Sodasaurus()
        {
            this.Calories = 112;
            this.Price = 1.5;

            ingredients.Add("Water");
            ingredients.Add("Cane Sugar");
        }
    }
}
