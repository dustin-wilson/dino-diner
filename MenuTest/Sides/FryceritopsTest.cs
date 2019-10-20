using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        [Fact]
        public void DescriptionDefaultShouldBeCorrect()
        {
            Fryceritops fr = new Fryceritops();
            Assert.Equal("Small Fryceritops", fr.Description);
        }

        [Fact]
        public void SwitchingToSmallDescriptionShouldBeCorrect()
        {
            Fryceritops fr = new Fryceritops();
            fr.Size = Size.Large;
            fr.Size = Size.Small;
            Assert.Equal("Small Fryceritops", fr.Description);
        }

        [Fact]
        public void SwitchingToMediumDescriptionShouldBeCorrect()
        {
            Fryceritops fr = new Fryceritops();
            fr.Size = Size.Medium;
            Assert.Equal("Medium Fryceritops", fr.Description);
        }

        [Fact]
        public void SwitchingToLargeDescriptionShouldBeCorrect()
        {
            Fryceritops fr = new Fryceritops();
            fr.Size = Size.Large;
            Assert.Equal("Large Fryceritops", fr.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Fryceritops fr = new Fryceritops();
            Assert.Empty(fr.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifyEveryone()
        {
            Fryceritops fr = new Fryceritops();
            Assert.PropertyChanged(fr, "Price", () =>
            {
                fr.Size = Size.Medium;
            });
            Assert.PropertyChanged(fr, "Description", () =>
            {
                fr.Size = Size.Medium;
            });
            Assert.PropertyChanged(fr, "Calories", () =>
            {
                fr.Size = Size.Medium;
            });
        }
    }
}
