/* PterodactylWings.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Lists the ingredients in the item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new instance of the item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
