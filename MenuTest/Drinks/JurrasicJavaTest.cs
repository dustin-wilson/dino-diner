using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void CorrectDefaults()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
            Assert.False(java.Ice);
            Assert.Equal<Size>(Size.Small, java.Size);
            Assert.False(java.RoomForCream);
        }

        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void CorrectValuesAfterSwitchSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void CorrectValuesAfterSwitchMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void CorrectValuesAfterSwitchLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }

        // That invoking AddIce() results in the Ice property being true
        [Fact]
        public void CorrectIceValueAfterAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void LeaveSpaceForCreamWorks()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        // The correct ingredients are given.
        [Fact]
        public void CorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
        }
    }
}
