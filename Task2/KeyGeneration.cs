using System;
using System.Linq;

namespace Laba5
{
    public static class KeyGeneration
    {
        public static int[] GetKey(string stringKey) => GenerationKey(stringKey);

        private static (char, int)[] SortString(string encryptionKey) => encryptionKey.Select((item, index) => (item, index)).
              OrderBy(item => item).ToArray();

        private static int[] GenerationKey(string stringKey)
        {
            var arrayKeyInt = new int[stringKey.Length];

            (char, int)[] sortKey = SortString(stringKey);

            ConvertKeyToCharArray(stringKey, ref sortKey);

            sortKey = sortKey.OrderBy(item => item.Item2).ToArray();

            CreateIntArrayKey(stringKey, ref arrayKeyInt, sortKey);

            return arrayKeyInt;
        }

        private static void CreateIntArrayKey(string stringKey, ref int[] arrayKeyInt, (char, int)[] sortKey)
        {
            for (int i = 0; i < stringKey.Length; i++)
            {
                arrayKeyInt[i] = Convert.ToInt32(sortKey[i].Item1);
            }
        }

        private static void ConvertKeyToCharArray(string stringKey, ref (char, int)[] sortKey)
        {
            for (int i = 0; i < stringKey.Length; i++)
            {
                sortKey[i].Item1 = Convert.ToChar(i + 1);
            }
        }
    }
}
