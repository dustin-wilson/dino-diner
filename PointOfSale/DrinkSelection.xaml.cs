/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Publick Constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches visibility of buttons if clicked
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void SodasaurusSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Visible;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Hidden;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;

            soda.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            tea.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            coffee.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            water.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Sets status of the ice button
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void NoIceSelect(object sender, RoutedEventArgs e)
        {
            if (iceButton.Content.Equals("Includes Ice"))
            {
                iceButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                iceButton.Content = "No Ice";
            }
            else
            {
                iceButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                iceButton.Content = "Includes Ice";
            }
        }

        /// <summary>
        /// Sets status of the lemon button
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void LemonSelect(object sender, RoutedEventArgs e)
        {
            if (lemonButton.Content.Equals("No Lemon"))
            {
                lemonButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                lemonButton.Content = "Includes Lemon";
            }
            else
            {
                lemonButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                lemonButton.Content = "No Lemon";
            }
        }


        /// <summary>
        /// Sets status of the sweet button
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void SweetSelect(object sender, RoutedEventArgs e)
        {
            if (sweetButton.Content.Equals("Unsweetened Tea"))
            {
                sweetButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                sweetButton.Content = "Sweet Tea";
            }
            else
            {
                sweetButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                sweetButton.Content = "Unsweetened Tea";
            }
        }

        /// <summary>
        /// Switches visibility of buttons if clicked
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void TeaSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;

            soda.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tea.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            coffee.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            water.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Switches visibility of buttons if clicked
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void JavaSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Hidden;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Visible;
            cafButton.Visibility = Visibility.Visible;

            soda.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tea.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            coffee.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            water.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// Switches visibility of buttons if clicked
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void WaterSelect(object sender, RoutedEventArgs e)
        {
            flavorButton.Visibility = Visibility.Hidden;
            iceButton.Visibility = Visibility.Visible;
            lemonButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Hidden;
            creamButton.Visibility = Visibility.Hidden;
            cafButton.Visibility = Visibility.Hidden;

            soda.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            tea.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            coffee.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            water.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
        }


        /// <summary>
        /// Sets status of the cream button
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void CreamSelect(object sender, RoutedEventArgs e)
        {
            if (creamButton.Content.Equals("Leave Room for Cream"))
            {
                creamButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                creamButton.Content = "No Room for Cream";
            }
            else
            {
                creamButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                creamButton.Content = "Leave Room for Cream";
            }
        }

        /// <summary>
        /// Sets status of the cream button
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void CafSelect(object sender, RoutedEventArgs e)
        {
            if (cafButton.Content.Equals("Caffenated"))
            {
                cafButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                cafButton.Content = "Decaf";
            }
            else
            {
                cafButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                cafButton.Content = "Caffenated";
            }
        }

        /// <summary>
        /// Moves to the flavor selection page
        /// </summary>
        /// <param name="sender">Object that is sending</param>
        /// <param name="e">Routed Event Argument</param>
        private void FlavorSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
