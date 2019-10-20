using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void EntreePriceShouldBeCorrect()
        {
            Entree entree = new PrehistoricPBJ();
            Order order = new Order(.10);
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(entree);
            order.Items = items;
            Assert.Equal(7.17, order.TotalCost, 2);
        }

        [Fact]
        public void PriceShouldBeCorrectWithMulipleItems()
        {
            Entree entree = new PrehistoricPBJ();
            Entree nugget = new DinoNuggets();
            Side fry = new Fryceritops();
            Drink water = new Water();
            Order order = new Order(.10);
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(entree);
            items.Add(nugget);
            items.Add(fry);
            items.Add(water);
            order.Items = items;
            Assert.Equal(13.05, order.TotalCost, 2);
        }

        [Fact]
        public void ComboShouldHaveCorrectPrice()
        {
            Entree burger = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Order order = new Order(.12);
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(combo);
            order.Items = items;
            Assert.Equal(11.97, order.TotalCost, 2);
        }

        [Fact]
        public void LargeComboShouldHaveCorrectPrice()
        {
            Entree burger = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            combo.Size = Size.Large;
            Order order = new Order(.12);
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(combo);
            order.Items = items;
            Assert.Equal(14.17, order.TotalCost, 2);
        }

        [Fact]
        public void SubtotalCostCannotBeNegative()
        {
            EntreeTestNegative entree = new EntreeTestNegative();
            Order order = new Order(.09);
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(entree);
            order.Items = items;
            Assert.Equal(0, order.TotalCost);
        }

        class EntreeTestNegative : IOrderItem
        {
            public string Description => throw new NotImplementedException();

            public string[] Special => throw new NotImplementedException();

            double IOrderItem.Price { get; } = -100;
        }
    }
}
