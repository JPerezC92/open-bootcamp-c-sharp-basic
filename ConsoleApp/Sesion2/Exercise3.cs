
namespace ConsoleApp.Sesion2
{
    class Exercise3
    {
        public void execute()
        {
            object myChar = 'a';
            byte myNumber = 18;

            bool isChar = myChar is char;

            Console.WriteLine($"a is a char: {isChar}");
            Console.WriteLine($"20 is greater than 18: {20> myNumber}");
            Console.WriteLine($"a is a char and 20 is greater than 18: {20 > myNumber && isChar}");
            Console.WriteLine($"a is a char or 17 is greater than 18: {20 > myNumber && isChar}");
        }
    }
}
