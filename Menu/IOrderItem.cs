/* IOrderItem.cs
 * Author: Dustin Wilson
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Description of item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Any special things about the item
        /// </summary>
        string[] Special { get; }
    }
}
