using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTwain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The aweful German Language");
            while (true)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.A) return;
                if (key == ConsoleKey.C) return;
                Console.Write("Hotfix 1");
            }
        }
    }
}
