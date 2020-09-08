/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Briarheart burger = new Briarheart();
            burger.Bun = false;
            Assert.False(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Briarheart burger = new Briarheart();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Briarheart burger = new Briarheart();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Briarheart burger = new Briarheart();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Briarheart burger = new Briarheart();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Price == 6.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Briarheart burger = new Briarheart();
            Assert.True(burger.Calories == 743);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            Briarheart burger = new Briarheart();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese)
            {
                Assert.Equal("Hold bun", burger.SpecialInstructions[0]);
                Assert.Equal("Hold ketchup", burger.SpecialInstructions[1]);
                Assert.Equal("Hold mustard", burger.SpecialInstructions[2]);
                Assert.Equal("Hold pickle", burger.SpecialInstructions[3]);
                Assert.Equal("Hold cheese", burger.SpecialInstructions[4]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Briarheart burger = new Briarheart();
            Assert.Equal("Briarheart Burger", burger.ToString());
        }
    }
}