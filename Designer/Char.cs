using System;

namespace ConsoleFramework.Designer
{
    public class Char
    {
        public static char Nullable = ' ';
        public static Char Empty = new Char{Symbol=Nullable,Back=ConsoleColor.Black,Fore=ConsoleColor.White};
        public char Symbol;
        public ConsoleColor Back;
        public ConsoleColor Fore;

        public Char()
        {
            Symbol = Nullable;
            Back = Con.Back;
            Fore = Con.Fore;
        }
        public Char(char c)
        {
            Symbol = c;
            Back = Con.Back;
            Fore = Con.Fore;
        }
        public Char(char c, ConsoleColor fore)
        {
            Symbol = c;
            Back = Con.Back;
            Fore = fore;
        }
        public Char(char c, ConsoleColor fore,ConsoleColor back)
        {
            Symbol = c;
            Back = back;
            Fore = fore;
        }

    }
}
