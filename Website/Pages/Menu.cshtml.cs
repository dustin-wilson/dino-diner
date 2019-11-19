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
        public Menu menu;

        /// <summary>
        /// Method ran when page navigated to
        /// </summary>
        public void OnGet()
        {
            menu = new Menu();
        }
    }
}