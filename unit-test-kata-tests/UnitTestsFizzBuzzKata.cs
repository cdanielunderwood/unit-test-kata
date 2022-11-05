using System;
using UnitTestKata;

namespace UnitTestKataTests
{
    public class UnitTestsFizzBuzzKata
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(17, "17")]
        [InlineData(30, "FizzBuzz")]
        public void FizzBuzz_TestNumber(int input, string expected)
        {
            Assert.Equal(expected, FizzBuzzKata.FizzBuzz(input));
        }
    }
}
