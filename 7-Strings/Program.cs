
namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
          
            string firstName = "Lucas";
            var lastName = "Ramalho";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}!", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3]{"Lucas", "Raquel", "Ana"};
            var formattedNames = string.Join("--", names);
            Console.WriteLine(formattedNames);


            var text = "\n-------\nHi Lucas\nLook into the following paths\nc:\\folder\\folder2\n";
            Console.WriteLine(text);

            var textVerbatingStrings = @"-------
Hi Lucas
Look into the following paths
c:\folder\folder2\
";
            Console.WriteLine(textVerbatingStrings);
             


        }

    }
}