
using System;
namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
           var random = new Random();
           for (var i = 0; i < 10; i++)
                Console.WriteLine("{0} - " + random.Next(20,100),i);


            var randmChar = new Random();
            for (var j = 0; j < 10; j++)
                Console.Write((char)random.Next(97,122));
            
            Console.WriteLine("");

            
            var randomPass = new Random();
            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var l = 0; l < passwordLength; l++)
                buffer[l] = (char)('a' + randomPass.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);

        }
          
    }
}