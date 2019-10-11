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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void SodasaurusSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Visible;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Hidden;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;
        }

        private void NoIceSelect(object sender, RoutedEventArgs e)
        {
            if (iceButton.Content.Equals("Includes Ice")) iceButton.Content = "No Ice";
            else iceButton.Content = "Includes Ice";
        }

        private void LemonSelect(object sender, RoutedEventArgs e)
        {
            if (lemonButton.Content.Equals("No Lemon")) lemonButton.Content = "Includes Lemon";
            else lemonButton.Content = "No Lemon";
        }

        private void SweetSelect(object sender, RoutedEventArgs e)
        {
            if (sweetButton.Content.Equals("Unsweetened Tea")) sweetButton.Content = "Sweet Tea";
            else sweetButton.Content = "Unsweetened Tea";
        }

        private void TeaSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;
        }

        private void JavaSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Hidden;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Visible;
            cafButton.Visibility = Visibility.Visible;
        }

        private void WaterSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;
        }

        private void CreamSelect(object sender, RoutedEventArgs e)
        {
            if (creamButton.Content.Equals("Leave Room for Cream")) creamButton.Content = "No Room for Cream";
            else creamButton.Content = "Leave Room for Cream";
        }

        private void CafSelect(object sender, RoutedEventArgs e)
        {
            if (cafButton.Content.Equals("Caffenated")) cafButton.Content = "Decaf";
            else cafButton.Content = "Caffenated";
        }

        private void FlavorSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
