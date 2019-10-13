/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fry Button click
        /// </summary>
        /// <param name="sender">Object sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void FrySelect(object sender, RoutedEventArgs e)
        {
            fries.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            mac.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            moz.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tot.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Mac Button click
        /// </summary>
        /// <param name="sender">Object sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void MacSelect(object sender, RoutedEventArgs e)
        {
            mac.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            fries.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            moz.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tot.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Moz Button click
        /// </summary>
        /// <param name="sender">Object sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void MozSelect(object sender, RoutedEventArgs e)
        {
            moz.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            mac.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            fries.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tot.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Tot Button click
        /// </summary>
        /// <param name="sender">Object sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void TotSelect(object sender, RoutedEventArgs e)
        {
            tot.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            mac.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            moz.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            fries.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}
