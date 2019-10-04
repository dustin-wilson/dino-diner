using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void CorrectDefaults()
        {
            JurassicJava java = new JurassicJava();
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
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void CorrectValuesAfterSwitchMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void CorrectValuesAfterSwitchLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }

        // That invoking AddIce() results in the Ice property being true
        [Fact]
        public void CorrectIceValueAfterAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void LeaveSpaceForCreamWorks()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        // The correct ingredients are given.
        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
        }
    }
}
