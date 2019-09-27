using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Boolean to indicate if room should be left for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Boolean for if coffee is to be decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Sets bool Ice to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        private Size size;

        /// <summary>
        /// Property to set Size and change corresponing properties
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
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Public Constructor for JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
            Price = .59;
            Calories = 2;
        }
    }
}
