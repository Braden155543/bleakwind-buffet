/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = false;
            Assert.False(philly.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Onion = false;
            Assert.False(philly.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Roll = false;
            Assert.False(philly.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Price == 7.23);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Calories == 784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = includeSirloin;
            philly.Onion = includeOnion;
            philly.Roll = includeRoll;

            if (!includeSirloin && !includeOnion && !includeRoll)
            {
                Assert.Equal("Hold sirloin", philly.SpecialInstructions[0]);
                Assert.Equal("Hold onions", philly.SpecialInstructions[1]);
                Assert.Equal("Hold roll", philly.SpecialInstructions[2]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Philly Poacher", philly.ToString());
        }
    }
}