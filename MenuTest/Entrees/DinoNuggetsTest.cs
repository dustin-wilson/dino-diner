﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(4.25, dn.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal<uint>(59*6, dn.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal(4.50, dn.Price, 2);
            dn.AddNugget();
            Assert.Equal(4.75, dn.Price, 2);
            dn.AddNugget();
            Assert.Equal(5.00, dn.Price, 2);
        }

        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }

        [Fact]
        public void SpecialShouldBeEmptyDefault()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);
        }

        [Fact]
        public void SpecialShouldRefeltAddNuggets()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Contains("1 Extra Nuggets", dn.Special);
        }

        [Fact]
        public void SpecialShouldReflectAddingMulipleNuggets()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            dn.AddNugget();
            dn.AddNugget();
            Assert.Contains("3 Extra Nuggets", dn.Special);
        }

        [Fact]
        public void AddingNuggetShouldNotifySpecialAndIngredientChange()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () =>
            {
                dn.AddNugget();
            });
            Assert.PropertyChanged(dn, "Ingredients", () =>
            {
                dn.AddNugget();
            });
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }
    }
}
