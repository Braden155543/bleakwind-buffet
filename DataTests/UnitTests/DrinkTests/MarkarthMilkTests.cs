/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.False(milk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small, milk.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = true;
            Assert.True(milk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = Size.Medium;
            Assert.Equal(Size.Medium, milk.Size);
            milk.Size = Size.Large;
            Assert.Equal(Size.Large, milk.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.True(milk.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.True(milk.Calories == cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = includeIce;

            if (includeIce) Assert.Equal("Add ice", milk.SpecialInstructions[0]);
            else Assert.Empty(milk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(name, milk.ToString());
        }
    }
}