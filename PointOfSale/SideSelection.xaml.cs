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
using DinoDiner.Menu;

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

        private DinoDiner.Menu.Side side;

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

            if (DataContext is Order order)
            {
                side = new Fryceritops();
                //order.Items.Add(side);
                order.Add(side);
            }
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

            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                //order.Items.Add(side);
                order.Add(side);
            }
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

            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                //order.Items.Add(side);
                order.Add(side);
            }
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

            if(DataContext is Order order)
            {
                side = new Triceritots();
                //order.Items.Add(side);
                order.Add(side);
            }
        }

        /// <summary>
        /// When radio buttons clicked
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Routed event argument</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
            }
        }
    }
}
