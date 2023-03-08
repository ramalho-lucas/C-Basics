
namespace CSharpFundamentals
{

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());//the writeLine function already converts to string, this is just an example on how to convert explicitily

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            
        }

    }
}