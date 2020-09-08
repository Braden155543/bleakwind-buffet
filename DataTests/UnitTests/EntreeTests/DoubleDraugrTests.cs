/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Bun = false;
            Assert.False(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Tomato = false;
            Assert.False(burger.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Mayo = false;
            Assert.False(burger.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Price == 7.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Calories == 843);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            burger.Tomato = includeTomato;
            burger.Lettuce = includeLettuce;
            burger.Mayo = includeMayo;

            if (!includeBun && !includeKetchup && !includeMustard && !includeMustard && !includePickle && !includeCheese && !includeTomato && !includeLettuce && !includeMayo)
            {
                Assert.Equal("Hold bun", burger.SpecialInstructions[0]);
                Assert.Equal("Hold ketchup", burger.SpecialInstructions[1]);
                Assert.Equal("Hold mustard", burger.SpecialInstructions[2]);
                Assert.Equal("Hold pickle", burger.SpecialInstructions[3]);
                Assert.Equal("Hold cheese", burger.SpecialInstructions[4]);
                Assert.Equal("Hold tomato", burger.SpecialInstructions[5]);
                Assert.Equal("Hold lettuce", burger.SpecialInstructions[6]);
                Assert.Equal("Hold mayo", burger.SpecialInstructions[7]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.Equal("Double Draugr", burger.ToString());
        }
    }
}