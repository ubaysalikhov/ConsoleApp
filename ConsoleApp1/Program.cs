using System;
using System.Collections.Generic;

/*
    aboveBelow

    accepts two arguments
    An unsorted collection of integers (the list)
    an integer (the comparison value)
    returns a hash/object/map/etc. with the keys "above" and "below" with the corresponding count of integers from the list that are aboveor     below the comparison value

    Example usage:

    input: [1, 5, 2, 1, 10], 6

    output: { "above": 1, "below": 4 }

    stringRotation

    accepts two arguments
      a string (the original string)
      a positive integer (the rotation amount)
      returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at     the beginning

      Example usage:

      input: "MyString", 2

      output: "ngMyStri"

    */

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            var result1 = AboveBelow(new List<int>() { 1, 5, 2, 1, 10 }, 5);

            Console.WriteLine("above: " + result1.above + ", below: " + result1.below + ", equals: " + result1.equals);

            Console.WriteLine(StringRotation("MyString", 2));
        }

        public static string StringRotation(string originalString, int rotationAmount)
        {
            var firstPart = originalString.Substring(originalString.Length - rotationAmount, rotationAmount);

            var secondPart = originalString.Substring(0, originalString.Length - rotationAmount);

            return firstPart + secondPart;
        }

        public static ComparisonObject AboveBelow(List<int> numbers, int comparisonValue)
        {
            var result = new ComparisonObject() { above = 0, below = 0, equals = 0 };

            foreach (var number in numbers)
            {
                if (number > comparisonValue) result.above++;
                else if (number == comparisonValue) result.equals++;
                else result.below++;
            }

            return result;
        }
    }

    public class ComparisonObject
    {
        public int above { get; set; }
        public int below { get; set; }
        public int equals { get; set; }
    }

}
