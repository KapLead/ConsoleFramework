using System;
using System.Text;
using ConsoleFramework.Core;
using ConsoleFramework.Designer;
using ConsoleFramework.Designer.Layers;

namespace ConsoleFrameworkTest1
{
    class Program : Con
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            new TableBuilder().Fore(ConsoleColor.DarkGray).T(ETable.OneBold)
                .Draw(ETabName.LT).Draw(ETabName.H, 20).Draw(ETabName.RT).NewRow()
                .Draw(ETabName.V).Draw(ETabName.Space, 20).Draw(ETabName.V)
                .CloneRow().CloneRow().CloneRow().CloneRow().CloneRow().CloneRow().CloneRow().CloneRow().NewRow()
                .Draw(ETabName.LD).Draw(ETabName.H, 20).Draw(ETabName.RD)
                .Draw(3,3);
            new TableBuilder().Fore(ConsoleColor.Gray).T(ETable.One)
                .Draw(ETabName.LT).Draw(ETabName.H, 16).Draw(ETabName.RT).NewRow()
                .Draw(ETabName.V).Draw(ETabName.Space, 16).Draw(ETabName.V)
                .CloneRow().CloneRow().CloneRow().CloneRow().CloneRow().NewRow()
                .Draw(ETabName.LD).Draw(ETabName.H, 16).Draw(ETabName.RD)
                .Draw(5, 5);
            new TableBuilder().Fore(ConsoleColor.DarkYellow).T(ETable.Two)
                .Draw(ETabName.LT).Draw(ETabName.H, 10).Draw(ETabName.RT).NewRow()
                .Draw(ETabName.V).Draw(ETabName.Space, 10).Draw(ETabName.V)
                .CloneRow().CloneRow().NewRow()
                .Draw(ETabName.LD).Draw(ETabName.H, 10).Draw(ETabName.RD)
                .Draw(7, 7);

            Console.ReadKey();
        }
    }
}
