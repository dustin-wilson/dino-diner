﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Menu = DinoDiner.Menu.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu;

        public DinoDiner.Menu.JurassicJava java = new DinoDiner.Menu.JurassicJava();

        public void OnGet()
        {
            menu = new Menu();
        }
    }
}