using System;

namespace Laba5
{
    public class Program
    {
        private static void Main()
        {
            string[] text = FileExtensions.Get();

            Console.WriteLine(ConvertingArrayToString.Get(text));

            TextExtensions.PrintEnglishText(ConvertingArrayToString.Get(text));
        }
    }
}
