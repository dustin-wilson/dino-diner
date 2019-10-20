using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
            Assert.True(tea.Ice);
            Assert.Equal<Size>(Size.Small, tea.Size);
            Assert.False(tea.Lemon);
            Assert.False(tea.Sweet);
        }

        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectValuesAfterChangingToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectValuesAfterChangingToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectValuesAfterChangingToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void IceFalseAfterHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void AddLemonMakesLemonTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        // That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void SettingSweetDoublesCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        // That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void SettingSweetBackToFalseRevertsCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Sweet = true;
            tea.Size = Size.Large;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //Correct Ingredients
        [Fact]
        public void CorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.DoesNotContain<string>("Lemon", ingredients);
            Assert.DoesNotContain<string>("Cane Sugar", ingredients);
        }

        [Fact]
        public void ContainsLemonIfAdded()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Lemon", ingredients);
        }

        [Fact]
        public void ContainsCaneSugarIfSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Cane Sugar", ingredients);
        }

        [Fact]
        public void DescriptionDefaultShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal("Small Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToSmallDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal("Small Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToMediumDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal("Medium Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToLargeDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal("Large Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToSweetSmallDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            tt.Sweet = true;
            Assert.Equal("Small Sweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToSweetMediumDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Sweet = true;
            Assert.Equal("Medium Sweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void SwitchingToSweetLargeDescriptionShouldBeCorrect()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Sweet = true;
            Assert.Equal("Large Sweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Empty(tt.Special);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.Contains("Add Lemon", tt.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.Contains("Hold Ice", tt.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifyEveryone()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Price", () =>
            {
                tt.Size = Size.Medium;
            });
            Assert.PropertyChanged(tt, "Description", () =>
            {
                tt.Size = Size.Medium;
            });
            Assert.PropertyChanged(tt, "Calories", () =>
            {
                tt.Size = Size.Medium;
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Special", () =>
            {
                tt.AddLemon();
            });
            Assert.PropertyChanged(tt, "Ingredients", () =>
            {
                tt.AddLemon();
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Special", () =>
            {
                tt.HoldIce();
            });
        }

        [Fact]
        public void ChangingSweetShouldNotifyDescription()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description", () =>
            {
                tt.Sweet = true;
            });
            Assert.PropertyChanged(tt, "Ingredients", () =>
            {
                tt.Sweet = true;
            });
        }
    }
}
