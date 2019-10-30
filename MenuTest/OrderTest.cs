using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            Order order = new Order();
            order.Add(entree);
            Assert.Equal(7.17, order.TotalCost, 2);
        }

        [Fact]
        public void PriceShouldBeCorrectWithMulipleItems()
        {
            Entree entree = new PrehistoricPBJ();
            Entree nugget = new DinoNuggets();
            Side fry = new Fryceritops();
            Drink water = new Water();
            Order order = new Order();
            order.Add(entree);
            order.Add(nugget);
            order.Add(fry);
            order.Add(water);
            Assert.Equal(13.05, order.TotalCost, 2);
        }

        [Fact]
        public void ComboShouldHaveCorrectPrice()
        {
            Entree burger = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Order order = new Order();
            order.Add(combo);
            Assert.Equal(11.76, order.TotalCost, 2);
        }

        [Fact]
        public void LargeComboShouldHaveCorrectPrice()
        {
            Entree burger = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            combo.Size = Size.Large;
            Order order = new Order();
            order.Add(combo);
            Assert.Equal(13.92, order.TotalCost, 2);
        }

        [Fact]
        public void SubtotalCostCannotBeNegative()
        {
            EntreeTestNegative entree = new EntreeTestNegative();
            Order order = new Order();
            order.Add(entree);
            Assert.Equal(0, order.TotalCost);
        }

        class EntreeTestNegative : IOrderItem
        {
            public string Description => throw new NotImplementedException();

            public string[] Special => throw new NotImplementedException();

            double IOrderItem.Price { get; } = -100;

            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
