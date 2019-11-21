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

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> itemType { get; set; } = new List<string>() { "combo", "entree", "side", "drink" };

        [BindProperty]
        public float minPrice { get; set; }

        [BindProperty]
        public float maxPrice { get; set; }

        /// <summary>
        /// Method ran when page navigated to
        /// </summary>
        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}