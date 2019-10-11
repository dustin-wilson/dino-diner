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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void BrontoSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Bronotowurst"));
        }

        private void NugSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Dino-Nuggets"));
        }

        private void PBSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&amp;J"));
        }

        private void WingSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Pterodactyl Wings"));
        }

        private void SteakosarusSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Steakosarus Burger"));
        }

        private void KingSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("T-Rex King Burger"));
        }

        private void WrapSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Veloci-Wrap"));
        }
    }
}
