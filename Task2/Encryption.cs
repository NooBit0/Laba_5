using System;
using System.Text;

namespace Laba5
{
    public static class Encryption
    {
        public static StringBuilder GetEncryptionString(string originalString, string stringKey) => EncryptionString(originalString, stringKey);

        private static StringBuilder EncryptionString(string originalString, string stringKey)
        {
            RemuveSpaceInOriginalString(ref originalString);

            var matrixOriginalChar = new char[CountTheNumberOfLines(originalString, stringKey), stringKey.Length];

            CreateOraiginalMatrixChar(originalString, stringKey, matrixOriginalChar);

            ShowMatrixChar(originalString, stringKey, matrixOriginalChar);

            return CreateEncryptStringBuilder(originalString, stringKey, matrixOriginalChar);
        }

        private static StringBuilder CreateEncryptStringBuilder(string originalString, string stringKey, char[,] matrixOriginalChar)
        {
            var encryptedString = new StringBuilder();
            int[] keyArray = KeyGeneration.GetKey(stringKey);
            int rowKey;

            for (int j = 0; j < stringKey.Length; j++)
            {
                rowKey = --keyArray[j];
                for (int i = 0; i < CountTheNumberOfLines(originalString, stringKey); i++)
                {
                    encryptedString.Append(matrixOriginalChar[i, rowKey]);
                }

                encryptedString.Append(" ");
            }

            return encryptedString;
        }

        private static string RemuveSpaceInOriginalString(ref string originalString) => originalString = originalString.Replace(" ", string.Empty);

        private static void CreateOraiginalMatrixChar(string originalString, string stringKey, char[,] matrixOriginalChar)
        {
            int index = 0;
            char[] originalChar = originalString.ToCharArray();

            for (int i = 0; i < CountTheNumberOfLines(originalString, stringKey); i++)
            {
                for (int j = 0; j < stringKey.Length; j++, index++)
                {
                    if (index == originalChar.Length)
                    {
                        break;
                    }

                    matrixOriginalChar[i, j] = originalChar[index];
                }
            }
        }

        private static void ShowMatrixChar(string originalString, string stringKey, char[,] matrixOriginalChar)
        {
            for (int i = 0; i < CountTheNumberOfLines(originalString, stringKey); i++)
            {
                for (int j = 0; j < stringKey.Length; j++)
                {
                    Console.Write(matrixOriginalChar[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int CountTheNumberOfLines(string originalString, string stringKey)
        {
            int countLines = originalString.Length / stringKey.Length;

            if (originalString.Length % stringKey.Length != 0)
            {
                countLines++;
            }

            return countLines;
        }
    }
}
