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
        private string entreeType;

        public CustomizeEntree(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Entree is DinoNuggets nuggets)
            {
                NuggetsButtons();
                entreeType = nuggets.ToString();
            }
            if (combo.Entree is Brontowurst bronto)
            {
                BrontoButtons();
                entreeType = bronto.ToString();
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
            }
            if (combo.Entree is TRexKingBurger king)
            {
                KingButtons();
                entreeType = king.ToString();
            }
            if (combo.Entree is VelociWrap wrap)
            {
                WrapButtons();
                entreeType = wrap.ToString();
            }
        }

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

        private void HoldCheese(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is VelociWrap wrap)
                wrap.HoldCheese();
        }

        private void HoldDressing(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is VelociWrap wrap)
                wrap.HoldDressing();
        }

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

        private void HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is TRexKingBurger king)
                king.HoldLettuce();
            if (combo.Entree is VelociWrap wrap)
                wrap.HoldLettuce();
        }

        private void HoldTomato(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is TRexKingBurger king)
                king.HoldTomato();
        }

        private void HoldMayo(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is TRexKingBurger king)
                king.HoldMayo();
        }

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

        private void HoldMustard(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldMustard();
            if (combo.Entree is TRexKingBurger king)
                king.HoldMustard();
        }

        private void HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldKetchup();
            if (combo.Entree is TRexKingBurger king)
                king.HoldKetchup();
        }

        private void HoldPickle(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldPickle();
            if (combo.Entree is TRexKingBurger king)
                king.HoldPickle();
        }

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

        private void HoldOnion(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst bronto)
                bronto.HoldOnion();
            if (combo.Entree is TRexKingBurger king)
                king.HoldOnion();
        }

        private void HoldPepper(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst bronto)
                bronto.HoldPeppers();
        }

        private void HoldBun(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst bronto)
                bronto.HoldBun();
            if (combo.Entree is SteakosaurusBurger steakosaurus)
                steakosaurus.HoldBun();
            if (combo.Entree is TRexKingBurger king)
                king.HoldBun();
        }

        public void NuggetsButtons()
        {
            Button addNugget = new Button()
            {
                Content = string.Format("Add 1 Nugget")
            };
            addNugget.Click += new RoutedEventHandler(AddNugget);
            stack.Children.Add(addNugget);
        }

        private void AddNugget(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is DinoNuggets nuggets)
                nuggets.AddNugget();
        }

        private void DonePressed(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(entreeType, combo));
        }
    }
}
