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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;

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

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                //order.Items.Add(drink);
                order.Add(drink);
            }
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
                drink.Ice = false;
            }
            else
            {
                iceButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                iceButton.Content = "Includes Ice";
                drink.Ice = true;
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
                if(drink is Water water)
                {
                    water.Lemon = true;
                }
                if(drink is Tyrannotea tea)
                {
                    tea.Lemon = true;
                }
            }
            else
            {
                lemonButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                lemonButton.Content = "No Lemon";
                if (drink is Water water)
                {
                    water.Lemon = false;
                }
                if (drink is Tyrannotea tea)
                {
                    tea.Lemon = false;
                }
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
                if(drink is Tyrannotea tea)
                {
                    tea.Sweet = true;
                }
            }
            else
            {
                sweetButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                sweetButton.Content = "Unsweetened Tea";
                if (drink is Tyrannotea tea)
                {
                    tea.Sweet = false;
                }
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

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                //order.Items.Add(drink);
                order.Add(drink);
            }
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

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                //order.Items.Add(drink);
                order.Add(drink);
            }
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

            if (DataContext is Order order)
            {
                drink = new Water();
                //order.Items.Add(drink);
                order.Add(drink);
            }
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
                if(drink is JurassicJava java)
                {
                    java.RoomForCream = false;
                }
            }
            else
            {
                creamButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                creamButton.Content = "Leave Room for Cream";
                if (drink is JurassicJava java)
                {
                    java.RoomForCream = true;
                }
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
                if(drink is JurassicJava java)
                {
                    java.Decaf = true;
                }
            }
            else
            {
                cafButton.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                cafButton.Content = "Caffenated";
                if (drink is JurassicJava java)
                {
                    java.Decaf = false;
                }
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

        /// <summary>
        /// When radio buttons clicked
        /// </summary>
        /// <param name="sender">object being sent</param>
        /// <param name="args">Routed event argument</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
            }
        }
    }
}
