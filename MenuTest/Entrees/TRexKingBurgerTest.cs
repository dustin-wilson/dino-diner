using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", tr.Description);
        }

        [Fact]
        public void SpecialShouldStartEmpty()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.Empty(tr.Special);
        }

        [Fact]
        public void HoldingBunShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            Assert.Contains("Hold Bun", tr.Special);
        }

        [Fact]
        public void HoldingLettuceShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldLettuce();
            Assert.Contains("Hold Lettuce", tr.Special);
        }

        [Fact]
        public void HoldingTomatoShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldTomato();
            Assert.Contains("Hold Tomato", tr.Special);
        }

        [Fact]
        public void HoldingOnionShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldOnion();
            Assert.Contains("Hold Onion", tr.Special);
        }

        [Fact]
        public void HoldingPickleShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldPickle();
            Assert.Contains("Hold Pickle", tr.Special);
        }

        [Fact]
        public void HoldingKetchupShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldKetchup();
            Assert.Contains("Hold Ketchup", tr.Special);
        }

        [Fact]
        public void HoldingMustardShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldMustard();
            Assert.Contains("Hold Mustard", tr.Special);
        }

        [Fact]
        public void HoldingMayoShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldMayo();
            Assert.Contains("Hold Mayo", tr.Special);
        }

        [Fact]
        public void HoldingAllShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldLettuce();
            tr.HoldMayo();
            tr.HoldMustard();
            tr.HoldOnion();
            tr.HoldPickle();
            tr.HoldTomato();
            Assert.Contains("Hold Bun", tr.Special);
            Assert.Contains("Hold Ketchup", tr.Special);
            Assert.Contains("Hold Lettuce", tr.Special);
            Assert.Contains("Hold Mayo", tr.Special);
            Assert.Contains("Hold Mustard", tr.Special);
            Assert.Contains("Hold Onion", tr.Special);
            Assert.Contains("Hold Pickle", tr.Special);
            Assert.Contains("Hold Tomato", tr.Special);
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldBun();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldBun();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldKetchup();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldLettuce();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingMayoShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldMayo();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldMayo();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldMustard();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldMustard();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldOnion();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldOnion();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldPickle();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldPickle();
            });
        }

        [Fact]
        public void HoldingTomatoShouldNotifySpecialAndIngredients()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldTomato();
            });
            Assert.PropertyChanged(tr, "Ingredients", () =>
            {
                tr.HoldTomato();
            });
        }
    }
}
