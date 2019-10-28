/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void BrontoSelect(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new Brontowurst());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void DinoNuggetSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DinoNuggets());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void PBJSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, "Entree"));
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void WingSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PterodactylWings());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void SteakosaurusSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new SteakosaurusBurger());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void TRexKingSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TRexKingBurger());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Selection of the entree item
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void WrapSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new VelociWrap());
                NavigationService.GoBack();
            }
        }
    }
}
