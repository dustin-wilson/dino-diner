﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCoa()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }


        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalorieAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalorieAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalorieAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldHaveCorrectBoolAfterHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        // Has correct ingredients
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Natural Flavors", ingredients);
            Assert.Contains("Cane Sugar", ingredients);
        }

        [Fact]
        public void DescriptionDefaultShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal("Small Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void SwitchingToSmallDescriptionShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            s.Size = Size.Small;
            Assert.Equal("Small Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void SwitchingToMediumDescriptionShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal("Medium Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void SwitchingToLargeDescriptionShouldBeCorrect()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal("Large Cola Sodasaurus", s.Description);
        }

        [Fact]
        public void ChangingFlavorShouldReflectInDescription()
        {
            Sodasaurus s = new Sodasaurus();
            s.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal("Small Lime Sodasaurus", s.Description);
            s.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal("Small Vanilla Sodasaurus", s.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.Contains("Hold Ice", s.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifyEveryone()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Price", () =>
            {
                s.Size = Size.Medium;
            });
            Assert.PropertyChanged(s, "Description", () =>
            {
                s.Size = Size.Medium;
            });
            Assert.PropertyChanged(s, "Calories", () =>
            {
                s.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingFlavorShouldNotifyDescription()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Description", () =>
            {
                s.Flavor = SodasaurusFlavor.Orange;
            });
        }

        [Fact]
        public void HoldingIceShouldNotifySpecial()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            });
        }
    }
}
