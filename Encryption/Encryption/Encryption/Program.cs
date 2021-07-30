using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Encryption
{
    class Program
    {
        static Encryptor _encryptor;

        static void Main(string[] args)
        {
            string pathToFile = @"E:\visual-studiop\C#July2021\Encryption\Encryption\Encryption\encryptedfile.txt";
            string passwordForEncryption = "asdasd324234234asdfasdfdfgasdf";

            Console.Write("Press any key to start the encryption");
            Console.ReadKey();
            _encryptor = new Encryptor("4345345345-34234-34234234");

            var encodingBytes = Encoding.Default.GetBytes("This is the string I want to encrypt. Hello World. Nice to meet you guys");

            var encryptedBytes = _encryptor.Encrypt(encodingBytes, passwordForEncryption);

            File.WriteAllBytes(pathToFile, encryptedBytes);
            Console.WriteLine("The file with the text encrypted has been created");
            Console.WriteLine("If you want to decrypt the data press any key");
            Console.ReadKey();

            Console.WriteLine("Start to Decrypting files");
            var encryptedBytes2 = File.ReadAllBytes(pathToFile);
            var decryptedBytes2 = _encryptor.Decrypt(encryptedBytes2, passwordForEncryption);
            var decryptedText = Encoding.Default.GetString(decryptedBytes2);

            Console.WriteLine("The message that was decrypted is: {0}", decryptedText);
            Console.Write("Press any key to exit");
            Console.ReadKey();



        }
    }
}
