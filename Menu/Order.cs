/* Order.cs
 * Author: Dustin Wilson
 */ 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Collection of the different items
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Cost of items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;

                foreach (IOrderItem item in Items)
                {
                    cost += item.Price;
                }

                if (cost > 0)
                    return cost;
                return 0;
            }
        }

        /// <summary>
        /// Rate of sales tax
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .10;
        
        /// <summary>
        /// Cost of tax
        /// </summary>
        public double SalesTaxCost
        {
            get { return (SalesTaxRate * SubtotalCost);  }
        }

        /// <summary>
        /// Total cost of items and tax
        /// </summary>
        public double TotalCost
        {
            get { return SalesTaxCost + SubtotalCost; }
        }
    }
}
