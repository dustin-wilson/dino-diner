/* MenuCategorySelection.xaml.cs
 * Author: Dustin Wilson
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the Combo Page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="args">Routed Event Argument</param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Navigates to the Drink Page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="args">Routed Event Argument</param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Navigates to the Entree Page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="args">Routed Event Argument</param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Navigates to the Side Page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="args">Routed Event Argument</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
