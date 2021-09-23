using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;
using Char = ConsoleFramework.Designer.Char;

namespace ConsoleFramework.Core
{
    public class TableBuilder
    {
        public List<List<Char>> Map => map;
        private List<List<Char>> map;
        private ETable _curtype = ETable.One;
        private ConsoleColor currFore, currBack;
        public TableBuilder()
        {
            map = new List<List<Char>>();
            NewRow();
        }
        public TableBuilder T(ETable type)
        {
            _curtype = type;return this;
        }
        public TableBuilder Back(ConsoleColor color)
        {
            currBack = color;return this;
        }
        public TableBuilder Fore(ConsoleColor color)
        {
            currFore = color;return this;
        }
        public TableBuilder NewRow()
        {
            map.Add(new List<Char>());return this;
        }
        public TableBuilder CloneRow()
        {
            map.Add(map.Last()); return this;
        }

        /// <summary> Прорисовка элемента символ таблицы </summary>
        public TableBuilder Draw(ETabName type,int count=1)
        {
            if (count < 1) count = 1;
            if (count > 80) count = 80;
            Char ch = new Char(type== ETabName.Space?' ':_curtype.Table()[type.GetIndex()],currFore,currBack);
            for (int i = 0; i < count; i++)
                map.Last().Add(ch);
            return this;
        }

        public string[] ToArray()
        {
            List<string> ret = new List<string>();
            foreach (List<Char> clist in map)
            {
                string tmp = Empty;
                foreach (var c in clist) tmp += c.Symbol;
                ret.Add(tmp);
            }
            return ret.ToArray();
        }

    }

}
