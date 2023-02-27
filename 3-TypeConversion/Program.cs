using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // implicit
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // explicit casting
            int j = 1;
            byte c = (byte) j;
            Console.WriteLine(c);

            
            // explicit casting
            int t = 1000; // terá perda de infos
            byte d = (byte) t;
            Console.WriteLine(d);

            // convert class
            var number = "1234";
            int m = Convert.ToInt32(number);
            Console.WriteLine(m);

            // try to convert class but get an exception
            try
            {
                var number2 = "1234";
                byte m2 = Convert.ToByte(number2);
                Console.WriteLine(m2);
            }
            catch
            {
                Console.WriteLine("The number could not be converted to a Byte");
            }

        }
    }
}