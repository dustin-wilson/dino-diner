using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void CheckDefaults()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
            Assert.True(water.Ice);
            Assert.Equal<Size>(Size.Small, water.Size);
            Assert.False(water.Lemon);
        }
        
        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void CorrectValuesAfterSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void CorrectValuesAfterMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void CorrectValuesAfterLarege()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void CorrectHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void CorrectAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
            List<string> ingredients = water.Ingredients;
            Assert.Contains("Lemon", ingredients);
        }

        // The correct ingredients are given.
        [Fact]
        public void CorrectIngredients()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.DoesNotContain("Lemon", ingredients);
        }
    }
}
