using DynamicProgramming.GridTraveler;
using System;
using Xunit;

namespace DynamicProgramming.UnitTests.GridTraveler
{
    public class GridTravelerBaseTests : GridTravelerBase
    {

        [Fact]
        public void Base_Class_Handles_Base_Case()
        {
            Assert.Equal(1, BaseCase(1, 1));
        }

        [Fact]
        public void Base_Class_Handles_Singularity()
        {
            var testee = new BruteForceGridTraveler();
            Assert.Equal(0, BaseCase(0, 1));
            Assert.Equal(0, BaseCase(1, 0));
        }

        public override long GridTraveler(long m, long n)
        {
            throw new NotImplementedException();
        }
    }
}
