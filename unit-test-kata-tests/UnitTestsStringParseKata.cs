using UnitTestKata;

namespace UnitTestKataTests
{
    public class UnitTestsStringParseKata
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
            Assert.Equal(expected, new StringParseKata().Add(input));
        }


        [Theory]
        [InlineData("//,\n2,\n3")]
        [InlineData("//,\nbanana")]
        [InlineData("//,\n1,2,")]
        [InlineData("//|\n1|2,3")]
        //[InlineData("//,\n1,-2")]
        public void StringCalculator_TestAdd_InvalidInput(string input)
        {
            Assert.ThrowsAny<Exception>(() => new StringParseKata().Add(input));
        }
    }


}

