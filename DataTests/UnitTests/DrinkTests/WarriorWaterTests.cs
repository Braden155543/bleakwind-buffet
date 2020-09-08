using Xunit;

using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater water = new WarriorWater();
            water.Ice = false;
            Assert.False(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater water = new WarriorWater();
            water.Lemon = true;
            Assert.True(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater water = new WarriorWater();
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            WarriorWater water = new WarriorWater();;
            Assert.True(water.Price == 0);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Calories == 0);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater water = new WarriorWater();
            water.Ice = includeIce;
            water.Lemon = includeLemon;

            if (!includeIce && includeLemon)
            {
                Assert.Equal("Hold ice", water.SpecialInstructions[0]);
                Assert.Equal("Add lemon", water.SpecialInstructions[1]);
            }
            else if (!includeIce && !includeLemon)
            {
                Assert.Equal("Hold ice", water.SpecialInstructions[0]);
            }
            else if (includeIce && includeLemon)
            {
                Assert.Equal("Add lemon", water.SpecialInstructions[0]);
            }
            else Assert.Empty(water.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater water = new WarriorWater();
            water.Size = size;
            Assert.Equal(name, water.ToString());
        }
    }
}
