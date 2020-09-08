/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.SausageLink = false;
            Assert.False(smoke.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.Egg = false;
            Assert.False(smoke.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.HashBrowns = false;
            Assert.False(smoke.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.Pancake = false;
            Assert.False(smoke.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Price == 5.62);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.True(smoke.Calories == 602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            smoke.SausageLink = includeSausage;
            smoke.Egg = includeEgg;
            smoke.HashBrowns = includeHashbrowns;
            smoke.Pancake = includePancake;

            if (!includeSausage && !includeEgg && !includeHashbrowns && !includePancake)
            {
                Assert.Equal("Hold sausage", smoke.SpecialInstructions[0]);
                Assert.Equal("Hold eggs", smoke.SpecialInstructions[1]);
                Assert.Equal("Hold hash browns", smoke.SpecialInstructions[2]);
                Assert.Equal("Hold pancakes", smoke.SpecialInstructions[3]);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton smoke = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", smoke.ToString());
        }
    }
}