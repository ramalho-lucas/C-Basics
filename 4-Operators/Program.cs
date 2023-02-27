using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine("Adição: " + (a+b));
            Console.WriteLine("Subtracao: "+ (a-b));
            Console.WriteLine("Multiplicacao: " + (a*b));

            Console.WriteLine("Divisao: "+ ((float)a) / (float)b);


            // Comparison
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);

            Console.WriteLine(a > b && b < a);
            Console.WriteLine(a > b || b > a);

        }
    }
}