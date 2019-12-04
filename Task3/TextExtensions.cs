using System;
using System.Text.RegularExpressions;

namespace Laba5
{
    public class TextExtensions
    {
        public static void PrintEnglishText(string text)
        {
            var regex = new Regex(@"([a-zA-Z]+[\W]*)");
            Console.WriteLine("\n\n");
            foreach (Match match in regex.Matches(text))
            {
                Console.Write(match.Groups[0].Value);
            }
        }
    }
}
