/* DinoNuggets.cs
 * Author: Dustin Wilson
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing Dino Nuggets
    /// </summary>
    public class DinoNuggets : Entree
    {        
        //Number of nuggets being ordered
        private uint numberNuggets;

        /// <summary>
        /// Lists ingredients in the instance
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };

                for(int i = 0; i < numberNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Creates an instance of the class
        /// Number of nuggets set to 6
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
            this.numberNuggets = 6;
        }

        /// <summary>
        /// Adds a nugget and adjusts the other properties
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.numberNuggets++;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Special");

        }

        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (numberNuggets > 6)
                {
                    uint numberOfExtraNuggets = numberNuggets - 6;
                    special.Add(numberOfExtraNuggets.ToString() + " Extra Nuggets");
                }
                return special.ToArray();
            }
        }
    }
}
