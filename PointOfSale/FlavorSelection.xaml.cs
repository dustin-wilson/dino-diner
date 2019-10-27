/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus sodasaurus;

        /// <summary>
        /// Public Constructor
        /// </summary>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            if(drink is Sodasaurus soda)
            {
                sodasaurus = soda;
            }
        }

        /// <summary>
        /// When flavor buttons clicked
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Routed event argument</param>
        private void OnFlavorSelect(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                sodasaurus.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(DinoDiner.Menu.SodasaurusFlavor), element.Tag.ToString());
                NavigationService.GoBack();
            }
        }
    }
}
