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
using Size = DinoDiner.Menu.Size;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        //Contains the menu object
        public Menu menu = new Menu();

        public IEnumerable<IMenuItem> entrees;
        public IEnumerable<IMenuItem> combos;
        public IEnumerable<IMenuItem> sides;
        public IEnumerable<IMenuItem> drinks;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> itemType { get; set; } = new List<string>() { "combo", "entree", "side", "drink" };

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        [BindProperty]
        public float minPrice { get; set; }

        [BindProperty]
        public float maxPrice { get; set; } = 12;

        /// <summary>
        /// Method ran when page navigated to
        /// </summary>
        public void OnGet()
        {
            combos = menu.AvailableMenuItems.OfType<CretaceousCombo>();
            entrees = menu.AvailableMenuItems.OfType<Entree>();
            sides = menu.AvailableMenuItems.OfType<Side>();
            drinks = menu.AvailableMenuItems.OfType<Drink>();
        }

        public void OnPost()
        {
            combos = menu.AvailableMenuItems.OfType<CretaceousCombo>();
            entrees = menu.AvailableMenuItems.OfType<Entree>();
            sides = menu.AvailableMenuItems.OfType<Side>();
            drinks = menu.AvailableMenuItems.OfType<Drink>();

            if (minPrice > 0 || maxPrice < 12) {
                combos = combos.Where(combo => combo.Price > minPrice && combo.Price < maxPrice);
                entrees = entrees.Where(combo => combo.Price > minPrice && combo.Price < maxPrice);
                sides = sides.Where(combo => combo.Price > minPrice && combo.Price < maxPrice);
                drinks = drinks.Where(combo => combo.Price > minPrice && combo.Price < maxPrice);
            }
            
            if (search != null)
            {
                combos = combos.Where(combo => combo.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                entrees = entrees.Where(combo => combo.Description.ToLower().Contains(search));
                sides = sides.Where(combo => combo.Description.ToLower().Contains(search));
                drinks = drinks.Where(combo => combo.Description.ToLower().Contains(search));
            }

            if (ingredients != null)
            {
                combos = combos.Where(combo => combo.Ingredients.Intersect(ingredients).Count() == 0);
                entrees = entrees.Where(combo => combo.Ingredients.Intersect(ingredients).Count() == 0);
                sides = sides.Where(combo => combo.Ingredients.Intersect(ingredients).Count() == 0);
                drinks = drinks.Where(combo => combo.Ingredients.Intersect(ingredients).Count() == 0);
            }
        }
    }
}