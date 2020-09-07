/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            Assert.False(apple.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            Assert.Equal(Size.Small , apple.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Ice = true;
            Assert.True(apple.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Size = Size.Medium;
            Assert.Equal(Size.Medium, apple.Size);
            apple.Size = Size.Large;
            Assert.Equal(Size.Large, apple.Size);
            apple.Size = Size.Small;
            Assert.Equal(Size.Small, apple.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Size = size;
            Assert.True(price == apple.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Size = size;
            Assert.True(cal == apple.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Ice = includeIce;

            if (includeIce) Assert.Equal("Add ice", apple.SpecialInstructions[0]);
            else Assert.Equal("", apple.SpecialInstructions[0]);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            apple.Size = size;
            Assert.Equal(name, apple.ToString());
        }
    }
}