
namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {

            // IF STATEMENT
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                 Console.WriteLine("It's morning");
            }
               
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
                
            else
            {
                Console.WriteLine("It's evening");
            }



            // CONDITIONAL OPERATOR
            bool isGoldCostumer = true;
            
            // float price;
            // if (isGoldCostumer)
            //     price = 19.95f;
            // else
            //     price = 29.95f;

            float price = (isGoldCostumer) ? 19.95f : 29.95f;

            Console.WriteLine(price);


            // SWITCH CASE
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's Spring and I like the flowers");
                    break;
                
                default:
                    Console.WriteLine("I don't understand this season");
                    break;

            }


                
        }
          
    }
}