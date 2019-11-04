/* CustomizePrehistoricPBJ.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;
        private string backLocation;

        /// <summary>
        /// Public Constructor
        /// </summary>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj, string backLocation)
        {
            InitializeComponent();
            this.pbj = pbj;
            this.backLocation = backLocation;
        }

        /// <summary>
        /// Holds the peanut butter
        /// </summary>
        /// <param name="sender">Object being sent</param>
        /// <param name="e">Routed event arg</param>
        private void OnHoldPB(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Holds the jelly
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Routed event arg</param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        private void DoneSelected(object sender, RoutedEventArgs e)
        {
            if (backLocation == "Combo")
                NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&J"));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
