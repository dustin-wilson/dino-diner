/* Drink.cs
 * Author: Dustin Wilson
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Drink : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        // Private backing for Ingredients
        protected List<string> ingredients = new List<string>();

        // Size private backing
        private Size size = Size.Small;

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;

                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        private bool ice = true;

        /// <summary>
        /// Indicates whether ice should be added
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Sets it so ice will not be an added ingredient
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Gives Description of the item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// String containing in there is anything special about the order
        /// </summary>
        public virtual string[] Special { get; }

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
