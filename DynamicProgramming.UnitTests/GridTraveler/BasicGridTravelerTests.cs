﻿using DynamicProgramming.GridTraveler;
using Xunit;

namespace DynamicProgramming.UnitTests.GridTraveler
{
   public class BasicGridTravelerTests
    {
        [Fact]
        public void Basic_Traveler_Handles_Base_Case()
        {
            var testee = new BasicGridTraveler();
            Assert.Equal(1, testee.GridTraveler(1, 1));
        }

        [Fact]
        public void Basic_Traveler_Handles_Singularity()
        {
            var testee = new BasicGridTraveler();
            Assert.Equal(0, testee.GridTraveler(0, 1));
            Assert.Equal(0, testee.GridTraveler(1, 0));
        }

        [Theory]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        public void Basic_Traveler_Calculates_Examples_Correctly(int m, int n, long expected)
        {
            var testee = new BasicGridTraveler();
            Assert.Equal(expected, testee.GridTraveler(m, n));
        }
    }
}
