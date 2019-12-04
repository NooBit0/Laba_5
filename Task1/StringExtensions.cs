using System;

namespace Laba5
{
    public static class StringExtensions
    {
        public static void GetComparisonResult(string a, string b)
        {
            if (CompareTheLtters(a, b))
            {
                Console.WriteLine("You can make a word!");
            }
            else
            {
                Console.WriteLine("You can't make a word!");
            }
        }

        private static int CountHowManyLettersInWord(string str, char b)
        {
            int startIndex = -1,
            count = 0;
            while ((startIndex = str.IndexOf(b, ++startIndex)) != -1)
            {
                ++count;
            }

            return count;
        }

        private static bool CompareTheLtters(string a, string b)
        {
            int count;
            for (int i = 0; i < b.Length; i++)
            {
                count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        count++;
                        if (CountHowManyLettersInWord(b, b[i]) > CountHowManyLettersInWord(a, b[i]))
                        {
                            return false;
                        }
                    }
                }

                if (count == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
