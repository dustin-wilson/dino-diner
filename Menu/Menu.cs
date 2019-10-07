/* Menu.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class Menu
    {
        /// <summary>
        /// List containing all available sides
        /// </summary>
        public List<string> AvailableSides
        {
            get
            {
                List<string> sides = new List<string>();
                sides.Add("Fryceritops");
                sides.Add("Meteor Mac and Cheese");
                sides.Add("Mezzorella Sticks");
                sides.Add("Triceritots");
                return sides;
            }
        } 

        /// <summary>
        /// List containing all available drinks
        /// </summary>
        public List<string> AvailableDrinks
        {
            get
            {
                List<string> drinks = new List<string>();
                drinks.Add("Jurassic Java");
                drinks.Add("Sodasaurus");
                drinks.Add("Tyrannotea");
                drinks.Add("Water");
                return drinks;
            }
        }

        /// <summary>
        /// List containing all available entrees
        /// </summary>
        public List<string> AvailableEnrees
        {
            get
            {
                List<string> entree = new List<string>();
                entree.Add("Brontowurst");
                entree.Add("Dino-Nuggets");
                entree.Add("Prehistoric PB&J");
                entree.Add("Pterodactyl Wings");
                entree.Add("Steakosaurus Burger");
                entree.Add("T-Rex King Burger");
                entree.Add("VelociWrap");
                return entree;
            }
        }

        /// <summary>
        /// List containing all available combos
        /// </summary>
        public List<string> AvailableCombos
        {
            get
            {
                List<string> combo = new List<string>();
                combo.Add("Brontowurst Combo");
                combo.Add("Dino-Nuggets Combo");
                combo.Add("Prehistoric PB&J Combo");
                combo.Add("Pterodactyl Wings Combo");
                combo.Add("Steakosaurus Burger Combo");
                combo.Add("T-Rex King Burger Combo");
                combo.Add("VelociWrap Combo");
                return combo;
            }
        }

        /// <summary>
        /// List containg all available menu items
        /// </summary>
        public List<string> AvailableMenuItems
        {
            get
            {
                List<string> menu = new List<string>();
                menu.AddRange(AvailableEnrees);
                menu.AddRange(AvailableDrinks);
                menu.AddRange(AvailableSides);
                menu.AddRange(AvailableCombos);
                return menu;
            }
        }

        public Menu() { }

        /// <summary>
        /// Representation of the class when ToString called
        /// </summary>
        /// <returns>Sring of items in menu</returns>
        public override string ToString()
        {
            return AvailableMenuItems.ToString();
        }
    }
}
