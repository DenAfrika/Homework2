using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernyshev
{
    public class SimpleHelperProgram
    {
        public static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Print(string args)
        {
            Console.WriteLine(args);
        }
    }
}
