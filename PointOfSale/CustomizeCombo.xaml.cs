/* CustomizeCombo.xaml.cs
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;

        public CustomizeCombo(string s)
        {
            InitializeComponent();
            entree.Content = "Customize " + s;
        }

        /// <summary>
        /// Public Constuctor for class
        /// </summary>
        /// <param name="s">Displays what combo user is customizing at top</param>
        /// <param name="combo">Combo being edited</param>
        public CustomizeCombo(string s, CretaceousCombo combo)
        {
            InitializeComponent();
            entree.Content = "Customize " + s;
            this.combo = combo;
        }

        /// <summary>
        /// Navigates to the drink selection page
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void DrinkSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        /// <summary>
        /// Navigates to the side selection page
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void SideSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Needs to go back because of the order
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="e">routed event argument</param>
        private void CustomizeSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// When radio buttons clicked
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Routed event argument</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                combo.Drink.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                combo.Side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
            }
        }
    }
}
