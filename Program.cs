using System;

namespace MaxProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max among 5, 10 and 15 is: " + MaxAmongIntegers(5, 10, 15));
        }
        /// <summary>
        /// Maximums the among integers.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>
        /// max integer
        /// </returns>
        public static int MaxAmongIntegers(int firstValue, int secondValue, int thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }

            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }

            if ((thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0))
            {
                return thirdValue;
            }

            return 0;
        }
        public static float MaxAmongFloat(float firstValue, float secondValue, float thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
                (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }

            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }

            if ((thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0) ||
                (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0))
            {
                return thirdValue;
            }

            return 0;
        }
        public static string MaxAmongStrings(string firstString, string secondString, string thirdString)
        {
            if ((firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0) ||
                (firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0) ||
                (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0))
            {
                return firstString;
            }

            if ((secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0) ||
                (secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0) ||
                (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0))
            {
                return secondString;
            }

            if ((thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(firstString) > 0) ||
                (thirdString.CompareTo(secondString) >= 0 && thirdString.CompareTo(firstString) > 0) ||
                (thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(firstString) >= 0))
            {
                return thirdString;
            }

            return "0";
        }
    }
}

