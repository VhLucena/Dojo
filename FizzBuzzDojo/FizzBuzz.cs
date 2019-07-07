using System;

namespace FizzBuzzDojo
{
    public class FizzBuzz
    {

        public string Get(int input)
        {
            string output = "";
            
            if (IsDivisibleByThree(input))
            {
                output += "Fizz";
            }

            if (IsDivisibleByFive(input))
            {
                output += "Buzz";
            }

            if (string.IsNullOrEmpty(output))
            {
                return input.ToString();
            }

            return output;
        }
        private bool IsDivisibleByThree(int input)
        {
            return IsDivisibleBy(3, input);
        }

        private bool IsDivisibleByFive(int input)
        {
            return IsDivisibleBy(5, input);
        }

        private bool IsDivisibleBy(int divisor, int input)
        {
            return IsZero(input % divisor);
        }

        private bool IsZero(int input)
        {
            return input == 0;
        }

    }
}
