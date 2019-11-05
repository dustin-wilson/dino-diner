/* CustomizeEntree.cs
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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        private CretaceousCombo combo;
        private Entree entree;
        private string entreeType;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="entree">entree</param>
        public CustomizeEntree(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
            if (entree is DinoNuggets nuggets)
            {
                NuggetsButtons();
                entreeType = nuggets.ToString();
            }
            if (entree is Brontowurst bronto)
            {
                BrontoButtons();
                entreeType = bronto.ToString();
            }
            if (entree is PterodactylWings wings)
            {
                entreeType = wings.ToString();
                DonePressed(new object(), new RoutedEventArgs());
            }
            if (entree is SteakosaurusBurger steakosaurus)
            {
                SteakosaurusButtons();
                entreeType = steakosaurus.ToString();
            }
            if (entree is TRexKingBurger king)
            {
                KingButtons();
                entreeType = king.ToString();
            }
            if (entree is VelociWrap wrap)
            {
                WrapButtons();
                entreeType = wrap.ToString();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="combo">combo</param>
        public CustomizeEntree(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Entree is DinoNuggets nuggets)
            {
                NuggetsButtons();
                entreeType = nuggets.ToString();
                entree = combo.Entree;
            }
            if (combo.Entree is Brontowurst bronto)
            {
                BrontoButtons();
                entreeType = bronto.ToString();
                entree = combo.Entree;
            }
            if (combo.Entree is PterodactylWings wings)
            {
                entreeType = wings.ToString();
                DonePressed(new object(), new RoutedEventArgs());
            }
            if (combo.Entree is SteakosaurusBurger steakosaurus)
            {
                SteakosaurusButtons();
                entreeType = steakosaurus.ToString();
                entree = combo.Entree;
            }
            if (combo.Entree is TRexKingBurger king)
            {
                KingButtons();
                entreeType = king.ToString();
                entree = combo.Entree;
            }
            if (combo.Entree is VelociWrap wrap)
            {
                WrapButtons();
                entreeType = wrap.ToString();
                entree = combo.Entree;
            }
        }

        /// <summary>
        /// Set wrap buttons
        /// </summary>
        public void WrapButtons()
        {
            Button holdLettuce = new Button();
            holdLettuce.Content = string.Format("Hold Lettuce");
            holdLettuce.Click += new RoutedEventHandler(HoldLettuce);
            stack.Children.Add(holdLettuce);

            Button holdDressing = new Button();
            holdDressing.Content = string.Format("Hold Dressing");
            holdDressing.Click += new RoutedEventHandler(HoldDressing);
            stack.Children.Add(holdDressing);

            Button holdCheese = new Button();
            holdCheese.Content = string.Format("Hold Cheese");
            holdCheese.Click += new RoutedEventHandler(HoldCheese);
            stack2.Children.Add(holdCheese);

        }

        /// <summary>
        /// hold cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldCheese(object sender, RoutedEventArgs e)
        {
            if (entree is VelociWrap wrap)
                wrap.HoldCheese();
        }

        /// <summary>
        /// hold dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldDressing(object sender, RoutedEventArgs e)
        {
            if (entree is VelociWrap wrap)
                wrap.HoldDressing();
        }

        /// <summary>
        /// set trex king button
        /// </summary>
        public void KingButtons()
        {
            Button holdBun = new Button();
            holdBun.Content = string.Format("Hold Bun");
            holdBun.Click += new RoutedEventHandler(HoldBun);
            holdBun.FontSize = 20;
            holdBun.Height = 50;
            stack.Children.Add(holdBun);

            Button holdPickle = new Button();
            holdPickle.Content = "Hold Pickle";
            holdPickle.Click += new RoutedEventHandler(HoldPickle);
            holdPickle.FontSize = 20;
            holdPickle.Height = 50;
            stack2.Children.Add(holdPickle);

            Button holdKetchup = new Button();
            holdKetchup.Content = "Hold Ketchup";
            holdKetchup.Click += new RoutedEventHandler(HoldKetchup);
            holdKetchup.FontSize = 20;
            holdKetchup.Height = 50;
            stack2.Children.Add(holdKetchup);

            Button holdMustard = new Button();
            holdMustard.Content = "Hold Mustard";
            holdMustard.Click += new RoutedEventHandler(HoldMustard);
            holdMustard.FontSize = 20;
            holdMustard.Height = 50;
            stack.Children.Add(holdMustard);

            Button holdLettuce = new Button();
            holdLettuce.Content = string.Format("Hold Lettuce");
            holdLettuce.Click += new RoutedEventHandler(HoldLettuce);
            holdLettuce.FontSize = 20;
            holdLettuce.Height = 50;
            stack.Children.Add(holdLettuce);

            Button holdTomato = new Button();
            holdTomato.Content = string.Format("Hold Tomato");
            holdTomato.Click += new RoutedEventHandler(HoldTomato);
            holdTomato.FontSize = 20;
            holdTomato.Height = 50;
            stack.Children.Add(holdTomato);

            Button holdOnion = new Button();
            holdOnion.Content = string.Format("Hold Onion");
            holdOnion.Click += new RoutedEventHandler(HoldOnion);
            holdOnion.FontSize = 20;
            holdOnion.Height = 50;
            stack2.Children.Add(holdOnion);

            Button holdMayo = new Button();
            holdMayo.Content = string.Format("Hold Mayo");
            holdMayo.Click += new RoutedEventHandler(HoldMayo);
            holdMayo.FontSize = 20;
            holdMayo.Height = 50;
            stack2.Children.Add(holdMayo);
        }

        /// <summary>
        /// Holds lettuc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger king)
                king.HoldLettuce();
            if (entree is VelociWrap wrap)
                wrap.HoldLettuce();
        }

        /// <summary>
        /// Hold tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldTomato(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger king)
                king.HoldTomato();
        }

        /// <summary>
        /// hold mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMayo(object sender, RoutedEventArgs e)
        {
            if (entree is TRexKingBurger king)
                king.HoldMayo();
        }

        /// <summary>
        /// Set steakosaurus buttons
        /// </summary>
        public void SteakosaurusButtons()
        {
            Button holdBun = new Button();
            holdBun.Content = string.Format("Hold Bun");
            holdBun.Click += new RoutedEventHandler(HoldBun);
            stack.Children.Add(holdBun);

            Button holdPickle = new Button();
            holdPickle.Content = "Hold Pickle";
            holdPickle.Click += new RoutedEventHandler(HoldPickle);
            stack.Children.Add(holdPickle);

            Button holdKetchup = new Button();
            holdKetchup.Content = "Hold Ketchup";
            holdKetchup.Click += new RoutedEventHandler(HoldKetchup);
            stack2.Children.Add(holdKetchup);

            Button holdMustard = new Button();
            holdMustard.Content = "Hold Ketchup";
            holdMustard.Click += new RoutedEventHandler(HoldMustard);
            stack2.Children.Add(holdMustard);
        }

        /// <summary>
        /// hold mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustard(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldMustard();
            if (entree is TRexKingBurger king)
                king.HoldMustard();
        }

        /// <summary>
        /// hold ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldKetchup();
            if (entree is TRexKingBurger king)
                king.HoldKetchup();
        }

        /// <summary>
        /// hold pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickle(object sender, RoutedEventArgs e)
        {
            if (entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldPickle();
            if (entree is TRexKingBurger king)
                king.HoldPickle();
        }

        /// <summary>
        /// set brontowurst buttons
        /// </summary>
        public void BrontoButtons()
        {
            Button holdBun = new Button();
            holdBun.Content = string.Format("Hold Bun");
            holdBun.Click += new RoutedEventHandler(HoldBun);
            stack.Children.Add(holdBun);

            Button holdPepper = new Button();
            holdPepper.Content = "Hold Pepper";
            holdPepper.Click += new RoutedEventHandler(HoldPepper);
            stack.Children.Add(holdPepper);

            Button holdOnion = new Button();
            holdOnion.Content = "Hold Onion";
            holdOnion.Click += new RoutedEventHandler(HoldOnion);
            stack2.Children.Add(holdOnion);

        }

        /// <summary>
        /// hold onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnion(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bronto)
                bronto.HoldOnion();
            if (entree is TRexKingBurger king)
                king.HoldOnion();
        }

        /// <summary>
        /// hold peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPepper(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bronto)
                bronto.HoldPeppers();
        }

        /// <summary>
        /// hold the bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun(object sender, RoutedEventArgs e)
        {
            if (entree is Brontowurst bronto)
                bronto.HoldBun();
            if (entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldBun();
            if (entree is TRexKingBurger king)
                king.HoldBun();
        }

        /// <summary>
        /// sets buttons for nuggets
        /// </summary>
        public void NuggetsButtons()
        {
            Button addNugget = new Button()
            {
                Content = string.Format("Add 1 Nugget")
            };
            addNugget.Click += new RoutedEventHandler(AddNugget);
            stack.Children.Add(addNugget);
        }

        /// <summary>
        /// adds a nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNugget(object sender, RoutedEventArgs e)
        {
            if (entree is DinoNuggets nuggets)
                nuggets.AddNugget();
        }

        /// <summary>
        /// operation for when the done button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DonePressed(object sender, RoutedEventArgs e)
        {
            if (combo == null)
                NavigationService.Navigate(new MenuCategorySelection());
            else
                NavigationService.Navigate(new CustomizeCombo(entreeType, combo));
        }
    }
}
