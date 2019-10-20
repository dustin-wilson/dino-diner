using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }

        [Fact]
        public void DescriptionDefaultShouldBeCorrect()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            Assert.Equal("Small Meteor Mac and Cheese", mm.Description);
        }

        [Fact]
        public void SwitchingToSmallDescriptionShouldBeCorrect()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            mm.Size = Size.Large;
            mm.Size = Size.Small;
            Assert.Equal("Small Meteor Mac and Cheese", mm.Description);
        }

        [Fact]
        public void SwitchingToMediumDescriptionShouldBeCorrect()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            mm.Size = Size.Medium;
            Assert.Equal("Medium Meteor Mac and Cheese", mm.Description);
        }

        [Fact]
        public void SwitchingToLargeDescriptionShouldBeCorrect()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            mm.Size = Size.Large;
            Assert.Equal("Large Meteor Mac and Cheese", mm.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            Assert.Empty(mm.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifyEveryone()
        {
            MeteorMacAndCheese mm = new MeteorMacAndCheese();
            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Medium;
            });
            Assert.PropertyChanged(mm, "Description", () =>
            {
                mm.Size = Size.Medium;
            });
            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Medium;
            });
        }
    }
}
