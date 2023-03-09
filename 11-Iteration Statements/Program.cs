
namespace Iteration
{

    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (var i=1; i<= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(String.Format("O numero {0} é par", i));
                }
            }

            // Foreach Loops
            var name = "John Smith";

            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //While Loops
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 != 0)
                    Console.WriteLine(String.Format("O numero {0} é impar",j));

                j++;
            }



            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;
            }
                
        }
          
    }
}