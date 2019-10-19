/* VelociWrap.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the VelociWrap item
    /// </summary>
    public class VelociWrap : Entree
    {
        //Represents if dressing should be added
        private bool dressing = true;
        //Represents if lettuce should be added
        private bool lettuce = true;
        //Represents if cheese should be added
        private bool cheese = true;

        /// <summary>
        /// Sets dressing field to false
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets lettuce field to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Sets cheese field to false
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Lists the ingredients in the item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new instance of the item
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;  
            this.Calories = 356;
        }

        /// <summary>
        /// Create defaut ToString Method
        /// </summary>
        /// <returns>String of what the item is</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns any special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}
