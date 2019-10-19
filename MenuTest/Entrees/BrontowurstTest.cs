using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void HoldBunShouldAddSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Contains("Hold Bun", bw.Special);
        }

        [Fact]
        public void HoldPeperShouldAddSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Contains("Hold Peppers", bw.Special);
        }

        [Fact]
        public void HoldOnionsShouldAddSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Contains("Hold Onions", bw.Special);
        }

        [Fact]
        public void HoldPepperOnionAndBunShouldAddToSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnion();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                });
        }

        [Fact]
        public void HoldBunShouldNotifySpecialAndIngredient()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldBun();
            });
        }

        [Fact]
        public void HoldPeppersShouldNotifySpecialAndIngredient()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldPeppers();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifySpecialAndIngredient()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldOnion();
            });
        }
    }

}
