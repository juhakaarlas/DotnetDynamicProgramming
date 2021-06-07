using Xunit;
using DynamicProgramming.ConstructProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.ConstructProblems.Tests
{
    public class MemoizedCanConstructTests
    {
        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, true)]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, false)]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, true)]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", 
                    new string[] { "e", "ee", "eee", "eeee", "eeee", "eeeee", "eeeeee" }, false)]
        public void Calculates_Example_Cases_Correctly(string target, string[] wordBank, bool expected)
        {
            var testee = new MemoizedCanConstruct();

            if (expected)
            {
                Assert.True(testee.CanConstruct(target, wordBank));
            }
            else
            {
                Assert.False(testee.CanConstruct(target, wordBank));
            }
        }
    }
}