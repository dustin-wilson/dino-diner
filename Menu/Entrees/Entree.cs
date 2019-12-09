/* Entree.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Returns any special instructions
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Returns the size of the item
        /// </summary>
        public Size Size { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke property changed to notify gui
        /// </summary>
        /// <param name="propertyName">Name of property changing</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}