using System;

namespace Laba5
{
    public class Program
    {
        private static void Main()
        {
            string stringA, stringB;
            Console.WriteLine("Input A: ");
            stringA = InputExtensions.InputSting();

            Console.WriteLine("Input B: ");
            stringB = InputExtensions.InputSting();

            StringExtensions.GetComparisonResult(stringA, stringB);
        }
    }
}
