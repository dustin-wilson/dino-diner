/* Menu.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
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
        /// Returns all sides a side object
        /// </summary>
        public List<IMenuItem> GetSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
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
        /// List containing all available drinks as Drink objects
        /// </summary>
        public List<IMenuItem> GetDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(new JurassicJava());
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
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
        /// List containing all available entrees as Entree objects
        /// </summary>
        public List<IMenuItem> GetEntrees
        {
            get
            {
                List<IMenuItem> entree = new List<IMenuItem>();
                entree.Add(new Brontowurst());
                entree.Add(new DinoNuggets());
                entree.Add(new PrehistoricPBJ());
                entree.Add(new PterodactylWings());
                entree.Add(new SteakosaurusBurger());
                entree.Add(new TRexKingBurger());
                entree.Add(new VelociWrap());
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
        /// List containing all available combos as Combo objects
        /// </summary>
        public List<IMenuItem> GetCombos
        {
            get
            {
                List<IMenuItem> combo = new List<IMenuItem>();
                combo.Add(new CretaceousCombo(new Brontowurst()));
                combo.Add(new CretaceousCombo(new DinoNuggets()));
                combo.Add(new CretaceousCombo(new PrehistoricPBJ()));
                combo.Add(new CretaceousCombo(new PterodactylWings()));
                combo.Add(new CretaceousCombo(new SteakosaurusBurger()));
                combo.Add(new CretaceousCombo(new TRexKingBurger()));
                combo.Add(new CretaceousCombo(new VelociWrap()));
                return combo;
            }
        }

        /// <summary>
        /// List containg all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                menu.AddRange(GetCombos);
                menu.AddRange(GetEntrees);
                menu.AddRange(GetSides);
                menu.AddRange(GetDrinks);
                return menu;
            }
        }

        /// <summary>
        /// Public Constructor
        /// </summary>
        public Menu() { }

        /// <summary>
        /// Representation of the class when ToString called
        /// </summary>
        /// <returns>Sring of items in menu</returns>
        public override string ToString()
        {
            return AvailableMenuItems.ToString();
        }

        /// <summary>
        /// Filters items that fall into a specific price range
        /// </summary>
        /// <param name="min">minium price of an item</param>
        /// <param name="max">max price of an item</param>
        /// <param name="items">list to sort through</param>
        /// <returns></returns>
        public List<IMenuItem> FilterPrice(float min, float max, List<IMenuItem> items)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                    result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Filters items based off the name
        /// </summary>
        /// <param name="searchString">name seeing if is included in the description</param>
        /// <param name="items">all items which meet the critera</param>
        /// <returns>list of items which meets the requirements</returns>
        public List<IMenuItem> FilterName(string searchString, List<IMenuItem> items)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                string description = item.Description.ToLower();
                if (description.Contains(searchString))
                    result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Makes sure none of the ingredients are in the listed items
        /// </summary>
        /// <param name="ingredients">ingredients user does not want in displayed items</param>
        /// <param name="items">list of items</param>
        /// <returns>list of items which meet requirements</returns>
        public List<IMenuItem> FilterIngredients(List<string> ingredients, List<IMenuItem> items)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            bool valid = true;

            foreach (IMenuItem item in items)
            {
                valid = true;

                foreach(string ingredient in ingredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                        valid = false;
                }

                if (valid)
                    result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Returns all possible ingredients
        /// </summary>
        public List<string> PossibleIngredients
        {
            get { return FindAllPossibleIngredients(); }
        }

        /// <summary>
        /// finds all the possible ingredients
        /// </summary>
        /// <returns>the list with the above</returns>
        public List<string> FindAllPossibleIngredients()
        {
            List<string> result = new List<string>();

            foreach(IMenuItem item in AvailableMenuItems)
            {
                foreach(string ingredient in item.Ingredients)
                {
                    if (!result.Contains(ingredient))
                        result.Add(ingredient);
                }
            }

            return result;
        }
    }
}
