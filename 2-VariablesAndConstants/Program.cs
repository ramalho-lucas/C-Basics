﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 6;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firsName = "Lucas";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firsName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} - {1}", byte.MinValue, byte.MaxValue);

        }
    }
}