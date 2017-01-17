using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace PrimeFactors.Test
{
    public class PrimeFactorsTests
    {
        private static List<int> List(params int[] values)
        {
            return values.ToList();
        }

        [Fact]
        public void TestOne()
        {
            List().ShouldBeEquivalentTo(PrimeFactors.Generate(1));
        }

        [Fact]
        public void TestTwo()
        {
            List(2).ShouldBeEquivalentTo(PrimeFactors.Generate(2));
        }

        [Fact]
        public void TestThree()
        {
            List(3).ShouldBeEquivalentTo(PrimeFactors.Generate(3));
        }

        [Fact]
        public void TestFour()
        {
            List(2, 2).ShouldBeEquivalentTo(PrimeFactors.Generate(4));
        }

        [Fact]
        public void TestSix()
        {
            List(2, 3).ShouldBeEquivalentTo(PrimeFactors.Generate(6));
        }

        [Fact]
        public void TestEight()
        {
            List(2,2,2).ShouldBeEquivalentTo(PrimeFactors.Generate(8));
        }

        [Fact]
        public void TestNine()
        {
            List(3,3).ShouldBeEquivalentTo(PrimeFactors.Generate(9));
        }

        [Fact]
        public void TestFourteen()
        {
            List(2,7).ShouldBeEquivalentTo(PrimeFactors.Generate(14));
        }

        [Fact]
        public void TestFifteen()
        {
            List(3,5).ShouldBeEquivalentTo(PrimeFactors.Generate(15));
        }
    }
}
