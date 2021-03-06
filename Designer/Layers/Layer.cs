using System;

namespace ConsoleFramework.Designer.Layers
{

    /// <summary> Слой графического экрана </summary>
    public class Layer
    {
        /// <summary> Дефолтный слой графического буфера </summary>
        public static Layer Empty = new Layer {Index = -1};
        
        /// <summary> Индекс слоя </summary>
        public int Index { get; private set; } = 0;
        
        private Char[,] _items = null;

        /// <summary> Символ слоя в указанных координатах </summary>
        public Char this[int x,int y]
        {
            get
            {
                return (x<0 || y<0 || x>=Con.Size.Width || y>=Con.Size.Height)
                    ? Char.Empty
                    : _items[x, y];
            }
            set
            {
                 if(x<0 || y<0 || x>=Con.Size.Width || y>=Con.Size.Height) return;
                 _items[x, y] = value;
            }
        }


        public Layer(int index=0)
        {
            Index = index;
            _items = new Char[(int)Con.Size.Width, (int)Con.Size.Height];
        }

        /// <summary> Очистка слоя </summary>
        public void Clear()
        {
            for (int y = 0; y < Con.Size.Height; y++)
                for (int x = 0; x < Con.Size.Width; x++)
                    _items[x, y] = Char.Empty;
        }

    }
}
