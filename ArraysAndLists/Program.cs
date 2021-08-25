using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Create an int Array and populate numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(int number in numbers)
            {
                if (number % 2 != 0)
                    odds.Add(number);
                else
                    evens.Add(number);
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach(int odd in odds)
            {
                Console.WriteLine($"\nHere is an odd number: {odd}. Wasn't that strange?");
            }

            foreach(int even in evens)
            {
                Console.WriteLine($"\nHere is an even number: {even}. That's a very level headed number");
            }
        }
    }
}
