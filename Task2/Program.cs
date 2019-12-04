using System;

namespace Laba5
{
    public class Program
    {
        private static void Main()
        {
            string originalString, encryptionKey;

            Console.WriteLine("Input original string: ");
            originalString = InputExtensions.InputSting();

            Console.WriteLine("Input key encription: ");
            encryptionKey = InputExtensions.InputSting();

            Console.WriteLine("Encription key:");

            foreach (var item in KeyGeneration.GetKey(encryptionKey))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Encryption string: {Encryption.GetEncryptionString(originalString, encryptionKey)}");
        }
    }
}
