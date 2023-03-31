using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Sesion4
{
    public class Exercise1
    {
        public static void Execute()
        {
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine($"{n} x 10 = {10 * n}");
                n = n + 1;
            }
        }
    }
}
