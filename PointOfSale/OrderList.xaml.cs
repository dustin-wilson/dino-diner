/* OrderList.xaml.cs
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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for when selection is changed
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="args">Event argument</param>
        private void OnSelectionChanged(Object sender, RoutedEventArgs args)
        {
            if (OrderItems.SelectedValue is CretaceousCombo combo)
            {
                NavigationService.Navigate(new CustomizeEntree(combo));
            }
            if (OrderItems.SelectedValue is Drink drink)
                NavigationService.Navigate(new DrinkSelection(drink));
        }

        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        //order.Items.Remove(item);
                        order.Remove(item);
                    }
                }
            }
        }

        public NavigationService NavigationService { get; set; }
    }
}
