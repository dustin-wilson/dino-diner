/* Menu.cshtml.cs
 * Author: Dustin Wilson
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Menu = DinoDiner.Menu.Menu;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        //Contains the menu object
        public Menu menu = new Menu();

        public List<IMenuItem> entrees;
        public List<IMenuItem> combos;
        public List<IMenuItem> sides;
        public List<IMenuItem> drinks;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> itemType { get; set; } = new List<string>() { "combo", "entree", "side", "drink" };

        [BindProperty]
        public float minPrice { get; set; }

        [BindProperty]
        public float maxPrice { get; set; } = 10;

        /// <summary>
        /// Method ran when page navigated to
        /// </summary>
        public void OnGet()
        {
            combos = menu.GetCombos;
            entrees = menu.GetEntrees;
            sides = menu.GetSides;
            drinks = menu.GetDrinks;
        }

        public void OnPost()
        {
            combos = menu.GetCombos;
            entrees = menu.GetEntrees;
            sides = menu.GetSides;
            drinks = menu.GetDrinks;

            if (minPrice > 0 || maxPrice < 10) {
                combos = menu.FilterPrice(minPrice, maxPrice, combos);
                entrees = menu.FilterPrice(minPrice, maxPrice, entrees);
                sides = menu.FilterPrice(minPrice, maxPrice, sides);
                drinks = menu.FilterPrice(minPrice, maxPrice, drinks);
            }
            
        }
    }
}