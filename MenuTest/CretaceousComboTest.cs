using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        #region Combos Description


        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void DescriptionShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        #endregion

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap")]
        public void SpecialShouldStartAsDefault(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Contains(name, combo.Special);
            Assert.Contains("Small Fryceritops", combo.Special);
            Assert.Contains("Small Cola Sodasaurus", combo.Special);
        }

        [Theory]
        [InlineData(typeof(MeteorMacAndCheese), "Small Meteor Mac and Cheese")]
        [InlineData(typeof(MezzorellaSticks), "Small Mezzorella Sticks")]
        [InlineData(typeof(Triceritots), "Small Triceritots")]
        [InlineData(typeof(Fryceritops), "Small Fryceritops")]
        public void SpecialShouldChangeSide(Type type, string name)
        {
            Entree entree = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(entree);
            Side side = (Side)Activator.CreateInstance(type);
            combo.Side = side;
            Assert.Contains(name, combo.Special);
        }

        [Theory]
        [InlineData(typeof(JurassicJava), "Small Jurassic Java")]
        [InlineData(typeof(Sodasaurus), "Small Cola Sodasaurus")]
        [InlineData(typeof(Tyrannotea), "Small Tyrannotea")]
        [InlineData(typeof(Water), "Small Water")]
        public void SpecialShouldChangeDrink(Type type, string name)
        {
            Entree entree = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(entree);
            Drink drink = (Drink)Activator.CreateInstance(type);
            combo.Drink = drink;
            Assert.Contains(name, combo.Special);
        }

        [Fact]
        public void MediumShouldChangeSpecial()
        {
            Entree entree = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Size = Size.Medium;
            Assert.Contains("Medium Fryceritops", combo.Special);
            Assert.Contains("Medium Cola Sodasaurus", combo.Special);
        }

        [Fact]
        public void LargeShouldChangeSpecial()
        {
            Entree entree = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Size = Size.Large;
            Assert.Contains("Large Fryceritops", combo.Special);
            Assert.Contains("Large Cola Sodasaurus", combo.Special);
        }

        [Fact]
        public void SmallShouldChangeSpecial()
        {
            Entree entree = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Size = Size.Medium;
            combo.Size = Size.Small;
            Assert.Contains("Small Fryceritops", combo.Special);
            Assert.Contains("Small Cola Sodasaurus", combo.Special);
        }

        [Fact]
        public void ChangingPropertiesShouldAddToSpecial()
        {
            PrehistoricPBJ entree = new PrehistoricPBJ();
            Water water = new Water();
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Drink = water;
            entree.HoldJelly();
            entree.HoldPeanutButter();
            water.AddLemon();
            Assert.Contains("Hold Jelly", combo.Special);
            Assert.Contains("Hold Peanut Butter", combo.Special);
            Assert.Contains("Add Lemon", combo.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifyDifferentProperties()
        {
            Entree entree = new VelociWrap();
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.PropertyChanged(combo, "Size", () =>
            {
                combo.Size = Size.Medium;
            });
            Assert.PropertyChanged(combo, "Special", () =>
            {
                combo.Size = Size.Medium;
            });
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Size = Size.Medium;
            });
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Size = Size.Medium;
            });
        }
    }
}
