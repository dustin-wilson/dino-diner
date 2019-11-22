/* IMenuItem.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Returns the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Returns number of Calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Returns the containing ingredients
        /// </summary>
        List<string> Ingredients { get; }

        /// <summary>
        /// Description of the item
        /// </summary>
        string Description { get; }
    }
}
