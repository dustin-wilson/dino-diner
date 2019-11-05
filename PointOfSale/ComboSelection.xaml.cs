/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Public Contructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void BrontoSelect(object sender, RoutedEventArgs e)
        {
            Brontowurst brontowurst = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(brontowurst);
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeEntree(combo));
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void NugSelect(object sender, RoutedEventArgs e)
        {
            DinoNuggets nuggets = new DinoNuggets();
            CretaceousCombo combo = new CretaceousCombo(nuggets);
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeEntree(combo));
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void PBSelect(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(pbj);
            if(DataContext is Order order)
            {
                order.Add(combo);
                NavigationService.Navigate(new CustomizeEntree(combo));
            }
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void WingSelect(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeCombo(combo.Entree.ToString(), combo));
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void SteakosarusSelect(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeEntree(combo));
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void KingSelect(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeEntree(combo));
        }

        /// <summary>
        /// Navigates to Customize Combo page
        /// </summary>
        /// <param name="sender">Object sent</param>
        /// <param name="e">Routed Event Argument</param>
        private void WrapSelect(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
            if (DataContext is Order order)
                order.Add(combo);
            NavigationService.Navigate(new CustomizeEntree(combo));
        }
    }
}
