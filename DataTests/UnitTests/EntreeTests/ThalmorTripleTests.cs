/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = false;
            Assert.False(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Tomato = false;
            Assert.False(burger.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mayo = false;
            Assert.False(burger.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bacon = false;
            Assert.False(burger.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Egg = false;
            Assert.False(burger.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Price == 8.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Calories == 943);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            burger.Tomato = includeTomato;
            burger.Lettuce = includeLettuce;
            burger.Mayo = includeMayo;
            burger.Bacon = includeBacon;
            burger.Egg = includeEgg;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato && !includeLettuce && !includeMayo && !includeBacon && !includeEgg)
            {
                Assert.Equal("Hold bun", burger.SpecialInstructions[0]);
                Assert.Equal("Hold ketchup", burger.SpecialInstructions[1]);
                Assert.Equal("Hold mustard", burger.SpecialInstructions[2]);
                Assert.Equal("Hold pickle", burger.SpecialInstructions[3]);
                Assert.Equal("Hold cheese", burger.SpecialInstructions[4]);
                Assert.Equal("Hold tomato", burger.SpecialInstructions[5]);
                Assert.Equal("Hold lettuce", burger.SpecialInstructions[6]);
                Assert.Equal("Hold mayo", burger.SpecialInstructions[7]);
                Assert.Equal("Hold bacon", burger.SpecialInstructions[8]);
                Assert.Equal("Hold egg", burger.SpecialInstructions[9]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", burger.ToString());
        }
    }
}