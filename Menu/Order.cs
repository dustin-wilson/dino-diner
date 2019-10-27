/* Order.cs
 * Author: Dustin Wilson
 */ 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
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

        /// <summary>
        /// Event handler of property changed notifications
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke property changed to notify gui
        /// </summary>
        /// <param name="propertyName">Name of property changing</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Public Constructor
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        /// <summary>
        /// Properties to notify there is a change
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Event argument</param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("Items");
        }

        private List<IOrderItem> items; 

        /// <summary>
        /// Array of order items
        /// </summary>
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Adds an item to a list
        /// </summary>
        /// <param name="item">Item which needs to be added</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Removes an item from a list
        /// </summary>
        /// <param name="item">Item which needs to be removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
    }
}
