using System;

namespace UnitTestKata
{
    public class FizzBuzzKata
    {
        public FizzBuzzKata()
        {
        }

        public static string FizzBuzz(int input)
        {
            if (IsFizz(input) && IsBuzz(input))
                return "FizzBuzz";
            else if (IsFizz(input))
                return "Fizz";
            else if (IsBuzz(input))
                return "Buzz";
            else
                return input.ToString();
        }

        private static bool IsFizz(int input)
        {
            if ((input % 3) == 0)
                return true;
            else
                return false;
        }

        private static bool IsBuzz(int input)
        {
            if ((input % 5) == 0)
                return true;
            else
                return false;
        }
    }
}

