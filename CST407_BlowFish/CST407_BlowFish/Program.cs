using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST407_BlowFish
{
    class Program
    {
        static void Main(string[] args)
        {
            var blowFish = new BlowFish();
            Console.WriteLine("Please enter a key: ");
            var key = Console.ReadLine();
            blowFish.SetupKey(key);
            Console.WriteLine("Please enter text to encrypt: ");
            var plainText = Console.ReadLine();
            var encrypted = blowFish.Encrypt(plainText);
            Console.WriteLine($"Encrypted text (hex): {encrypted}");
            Console.WriteLine("Please enter text to decrypt: ");
            var cipherText = Console.ReadLine();
            var decrypted = blowFish.Decrypt(cipherText);
            Console.WriteLine($"Decrypted text: {decrypted}");
            Console.ReadLine();
        }
    }
}
