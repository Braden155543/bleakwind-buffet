/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Brocoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            lette.Brocoli = false;
            Assert.False(lette.Brocoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            lette.Mushrooms = false;
            Assert.False(lette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            lette.Tomato = false;
            Assert.False(lette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            lette.Cheddar = false;
            Assert.False(lette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Price == 4.57);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.True(lette.Calories == 404);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            lette.Brocoli = includeBroccoli;
            lette.Mushrooms = includeMushrooms;
            lette.Tomato = includeTomato;
            lette.Cheddar = includeCheddar;

            if (!includeBroccoli && !includeMushrooms && !includeTomato && !includeCheddar)
            {
                Assert.Equal("Hold broccoli", lette.SpecialInstructions[0]);
                Assert.Equal("Hold mushrooms", lette.SpecialInstructions[1]);
                Assert.Equal("Hold tomato", lette.SpecialInstructions[2]);
                Assert.Equal("Hold cheddar", lette.SpecialInstructions[3]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette lette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", lette.ToString());
        }
    }
}