/* MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            OrderItems.NavigationService = OrderUI.NavigationService;
        }

        /// <summary>
        /// Passes DataContext to the next page
        /// </summary>
        private void PassDataContentToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// Method ran once page is loaded
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Navigation Event Argument</param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Method ran when DataContext is changed
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="e">DependencyPropertyChangedEventArgs</param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Button to navigate back to category selection
        /// </summary>
        /// <param name="sender">Whats being sent</param>
        /// <param name="e">Routed event argument</param>
        private void OnReturnSelect(object sender, RoutedEventArgs e)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
