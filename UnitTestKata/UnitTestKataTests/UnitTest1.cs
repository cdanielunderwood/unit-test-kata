namespace UnitTestsKata1Tests
{
    public class UnitTestsKata1
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
            Assert.Equal(expected, Kata1.FizzBuzz(input));
        }
    }

    public class UnitTestsKata2
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("//,\n1", 1)]
        [InlineData("//,\n1,2", 3)]
        [InlineData("//,\n2,2", 4)]
        [InlineData("//,\n2,2,2", 6)]
        [InlineData("//,\n1,2,3", 6)]
        [InlineData("//;\n1;3", 4)]
        [InlineData("//|\n1|2|3", 6)]
        [InlineData("//sep\n2sep5", 7)]
        public void StringCalculator_TestAdd(string input, int expected)
        {
            Assert.Equal(expected, new Kata2().Add(input));
        }


        [Theory]
        [InlineData("//,\n2,\n3")]
        [InlineData("//,\nbanana")]
        [InlineData("//,\n1,2,")]
        [InlineData("//|\n1|2,3")]
        //[InlineData("//,\n1,-2")]
        public void StringCalculator_TestAdd_InvalidInput(string input)
        {
            Assert.ThrowsAny<Exception>(() => new Kata2().Add(input));
        }
    }


}

