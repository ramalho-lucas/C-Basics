﻿
namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
          
            // int[] numbers = new int[3];

            var numbers = new int[3] {1, 10, 25};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3];
            names[0] = "Lucas";
            names[1] = "Raquel";
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);


        }

    }
}