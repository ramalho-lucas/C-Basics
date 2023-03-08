using CSharpFundamentals.Math;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Person lucas = new Person();
            lucas.FirstName = "Lucas";
            lucas.LastName = "Ramalho";
            lucas.Introduce();


            Calculator calculator = new Calculator();
            calculator.Add(10,5);
            
        }

    }
}