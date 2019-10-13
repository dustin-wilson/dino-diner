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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Public Constuctor for class
        /// </summary>
        /// <param name="s">Displays what combo user is customizing at top</param>
        public CustomizeCombo(string s)
        {
            InitializeComponent();
            entree.Text = s;
        }

        /// <summary>
        /// Navigates to the drink selection page
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void DrinkSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Navigates to the side selection page
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void SideSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
