using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing Prehistoric PB&amp;J
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        // Represents if peanut butter should be added
        private bool peanutButter = true;
        // Represents if jelly should be added
        private bool jelly = true;

        /// <summary>
        /// Lists the Ingredients in the item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new instance
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Changes peanut butter property to false
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets jelly property to false
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
