/* Water.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        ///  Boolean property for lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Sets lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// returns which ingredients are in the item       
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
