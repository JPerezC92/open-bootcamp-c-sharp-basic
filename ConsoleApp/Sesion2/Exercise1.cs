using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sesion2
{
    class Exercise1
    {
        public void execute()
        {

            Console.WriteLine("Please give us the next information:");
            Console.WriteLine("First name:");
            string? firstName= Console.ReadLine();

            Console.WriteLine("Last name:");
            string? lastName = Console.ReadLine();

            Console.WriteLine("Age:");
            string? age= Console.ReadLine();

            Console.WriteLine("Do you know programming:");
            string? knowProgramming = Console.ReadLine();
                        

            string message = $"\nYour information is:\nName: {firstName} {lastName}\nAge: {age}\nKnow programming: {knowProgramming}";

            Console.Write(message);
        }
    }
}
