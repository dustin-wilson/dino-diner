using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        // Private backing for size
        private Size size;

        // Private backing for Calories
        private uint calories;

        /// <summary>
        /// Property of if tea is sweet
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Property of if should add lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Get and Set the size
        /// Also adjust price and calories
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
                        Price = 0.99;
                        calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        calories = 32;
                        break;
                }
            }
        }

        /// <summary>
        /// Adds a lemon by setting bool to true and adds to ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// Override ingredients so can check if need sugar
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        public override uint Calories
        {
            get
            {
                if (Sweet) return calories * 2;
                else return calories;
            }
        }

        /// <summary>
        /// Constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Size = Size.Small;

            ingredients.Add("Water");
            ingredients.Add("Tea");
        }
    }
}
