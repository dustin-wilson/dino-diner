/* CretaceousCombo.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Contain entree user wants in their combo
        /// </summary>
        public Entree Entree { get; set; }

        private Side side;

        /// <summary>
        /// Side which user wants
        /// </summary>
        public Side Side
        {
            get { return side; }

            set
            {
                side = value;
                Side.Size = size;
            }
        }

        private Drink drink;

        /// <summary>
        /// Drink which user wants
        /// </summary>
        public Drink Drink {

            get { return drink; }

            set
            {
                drink = value;
                Drink.Size = size;
            }
        }

        /// <summary>
        /// Total price of each item
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }
        }

        /// <summary>
        /// Sum of each item's calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        private Size size = Size.Small;

        /// <summary>
        /// Total combo size which applies to side and drink
        /// </summary>
        public Size Size
        {
            get { return size; }

            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// All ingredients in each item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        
        /// <summary>
        /// Public constructor for entree
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
    }
}
