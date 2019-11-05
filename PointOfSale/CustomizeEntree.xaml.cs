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
                entreeType = "Dino-Nuggets";
            }
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
