using System;

namespace Laba5
{
    public static class InputExtensions
    {
        public static string InputSting()
        {
            string tempString;
            try
            {
                tempString = Console.ReadLine();
                if (tempString == string.Empty)
                {
                    throw new Exception("Exception: invalid input!");
                }
            }
            catch (Exception ex)
            {
                tempString = null;
                Console.WriteLine(ex.Message);
                System.Environment.Exit(-1);
            }

            return tempString;
        }
    }
}
