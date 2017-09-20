using System;
using TextJustifier.Core;

namespace TextJustifier.ConsoleApp
{
    class EntryPoint
    {
        static void Main()
        {
            var justifier = new Justifier();
            Console.WriteLine(justifier.Justify("a b c", 5));
            Console.Read();
        }
    }
}
