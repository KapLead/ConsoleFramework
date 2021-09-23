using System;
using System.Collections.Generic;
using Char = ConsoleFramework.Designer.Char;

namespace ConsoleFramework.Core
{
    public static class Table
    {

        public static TableBuilder Draw(this TableBuilder table,int x=0,int y=0)
        {
            int dx = x, dy = y;

            foreach (List<Char> c in table.Map)
            {
                foreach (Char c1 in c)
                {
                    Console.SetCursorPosition(dx,dy);
                    Console.BackgroundColor = c1.Back;
                    Console.ForegroundColor = c1.Fore;
                    Console.Write(c1.Symbol);
                    dx++;
                }
                dx = x;
                dy++;
            }
            return table;
        }


    }
}
