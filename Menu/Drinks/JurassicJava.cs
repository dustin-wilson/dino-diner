/* JurassicJava.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        bool cream = false;
        /// <summary>
        /// Boolean to indicate if room should be left for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return cream; }
            set
            {
                cream = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Boolean for if coffee is to be decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets bool Ice to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
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

                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Makes the list of ingredients immutable
        /// Returns the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingredients = new List<string>();

                ingredients.Add("Water");
                ingredients.Add("Coffee");

                return ingredients;
            }
        }

        /// <summary>
        /// Public Constructor for JurrasicJava
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Price = .59;
            Calories = 2;
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            if (!Decaf)
            {
                switch (size)
                {
                    case Size.Small:
                        return "Small Jurassic Java";
                    case Size.Medium:
                        return "Medium Jurassic Java";
                    case Size.Large:
                        return "Large Jurassic Java";
                }
            } else
            {
                switch (size)
                {
                    case Size.Small:
                        return "Small Decaf Jurassic Java";
                    case Size.Medium:
                        return "Medium Decaf Jurassic Java";
                    case Size.Large:
                        return "Large Decaf Jurassic Java";
                }
            }
            return base.ToString();
        }

        /// <summary>
        /// Special order instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }
    }
}
