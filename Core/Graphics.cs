using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleFramework.Core
{
    public enum ETabName
    {
        /// <summary> Горизонтальная линия таблицы </summary>
        H=0,
        /// <summary> Вертикальная линия таблицы </summary>
        V = 1,
        /// <summary> Левый верхний угол таблицы </summary>
        LT=2,
        /// <summary> Правый верхний угол таблицы</summary>
        RT = 3,
        /// <summary> Левый нижний угол таблицы </summary>
        LD = 4,
        /// <summary> Правый нижняя середина таблицы</summary>
        RD = 5,
        /// <summary> Верхняя середина таблицы </summary>
        MT=6,
        /// <summary> Нижяя середина таблицы </summary>
        MD = 7,
        /// <summary> Середина таблицы </summary>
        MM = 8,
        /// <summary> Девая середина таблицы </summary>
        LM = 9,
        /// <summary> Правая середина таблицы </summary>
        RM=10,
        Space=11
    }
    public static class Graphics
    {
        private static string t1 = "─│┌┐└┘┬┴┼├┤";
        private static string t12= "━┃┏┓┗┛┳┻╋┣┫";
        private static string t2 = "═║╔╗╚╝╦╩╬╠╣";

        private static string bo = "▛▜" +
                                   "▙▟" +
                                   "▚▞";

        public static string ant = "▅▆▇▉";
        private static string bb = "╭─╮" +
                                   "╰─╯";

        private static string back = "░▒▓█";

        private static string  vert = "│┃┆┇┊┋",
                                hor = "─━┄┅┈┉";

        public static string Table(this ETable t)
        {
            switch (t)
            {
                case ETable.One: return t1;
                case ETable.OneBold: return t12;
                case ETable.Two: return t2;
                default: return t1;
            }
        }

        public static int GetIndex(this ETabName tablename) => (int) tablename;

    }
}
