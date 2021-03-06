using System;
using ConsoleFramework.Designer.Layers;

namespace ConsoleFramework.Designer
{
    public partial class Con
    {
        /// <summary> Размер области просмотра </summary>
        public static Size Size 
        {
            get => new Size(Console.WindowWidth, Console.WindowHeight);
            set
            {
                Console.WindowWidth = (int)value.Width;
                Console.WindowHeight = (int)value.Height;
            }
        }

        /// <summary> Размер буфера </summary>
        public static Size Buffer 
        {
            get => new Size(Console.BufferWidth, Console.BufferHeight);
            set
            {
                Console.BufferWidth = (int)value.Width;
                Console.BufferHeight = (int)value.Height;
            }
        }

        /// <summary> Позиция курсора </summary>
        public static Point Cursor 
        {
            get => new Point((int)Console.CursorLeft,(int)Console.CursorTop);
            set
            {
                Console.CursorLeft = (int)value.X;
                Console.CursorTop = (int)value.Y;
            }
        }
        
        /// <summary> Текцщий цвет фона </summary>
        public static ConsoleColor Back
        {
            get => Console.BackgroundColor;
            set => Console.BackgroundColor = value;
        }

        /// <summary> Текущий цвет символов </summary>
        public static ConsoleColor Fore
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        static Con()
        {
            InitialBuffer(Size);
        }


    }
}
