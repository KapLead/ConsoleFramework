using System;

namespace ConsoleFramework.Designer
{
    public class Char
    {
        public static char Nullable = '\0';
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

    }
}
