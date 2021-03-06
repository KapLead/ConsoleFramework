using System;
using System.Collections.Generic;

namespace ConsoleFramework.Designer.Layers
{
    public class LayerCollection
    {

        public bool BlockPaint { get; private set; } = false;

        private List<Layer> _items = new List<Layer>();

        public LayerCollection()
        {
            for (int l=0; l<Con.ZIndexCount;l++)
            {
                _items.Add(new Layer(l));
            }
        }

        /// <summary> Очистка слоя </summary>
        public void Clear()
        {
            for (int l = 0; l < Con.ZIndexCount; l++)
                _items[l].Clear();
        }

        /// <summary> Получение видимого символа в указанных координатах </summary>
        private Char GetCharVisible(int x, int y)
        {
            if (x < 0 || y < 0 || 
                x >= Con.Size.Width || y>= Con.Size.Height)
                return Char.Empty;
            for (int l = Con.ZIndexCount - 1; l >= 0; l--)
            {
                var c = _items[l][x,y];
                if (c.Symbol != Char.Nullable)
                    return c;
            }
            return Char.Empty;
        }

        /// <summary> Итоговый слой </summary>
        private Layer ResultLayer()
        {
            var ret = Layer.Empty;
            for (int y = 0; y < Con.Size.Height; y++) // перебираем по У
            for (int x = 0; x < Con.Size.Width; x++) // перебираем по Х
            {
                ret[x, y] = GetCharVisible(x, y);
                if (ret[x, y].Symbol == Char.Nullable) // заменим нулевой символ пробелом
                    ret[x, y].Symbol = ' ';
            }
            return ret;
        }

        /// <summary> Отрисовка результирующего слоя </summary>
        public virtual void OnPaint()
        {
            if (BlockPaint) return;
            BlockPaint = true;
            var cursor = Con.Cursor;
            var visible = Console.CursorVisible;
            Console.CursorVisible = false;
            for (int y = 0; y < Con.Size.Height; y++) // перебираем по У
            for (int x = 0; x < Con.Size.Width; x++) // перебираем по Х
            {
                var c = GetCharVisible(x, y);
                if (c.Symbol == Char.Nullable) // заменим нулевой символ пробелом
                    c.Symbol = ' ';
                Con.Back = c.Back;
                Con.Fore = c.Fore;
                Con.Cursor = new Point(x,y);
                Console.Write(c.Symbol);
            }
            Con.Cursor = cursor;
            Console.CursorVisible = visible;
            BlockPaint = false;
        }
    }
}
