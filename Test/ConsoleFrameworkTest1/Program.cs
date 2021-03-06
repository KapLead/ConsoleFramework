using System;
using ConsoleFramework.Designer;
using ConsoleFramework.Designer.Layers;

namespace ConsoleFrameworkTest1
{
    class Program : Con
    {
        static void Main(string[] args)
        {
            Size = Buffer = new Size(80, 35);

            Console.ReadKey();
        }
    }
}
