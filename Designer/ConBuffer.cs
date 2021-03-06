using System;
using System.Windows.Forms;
using ConsoleFramework.Designer.Layers;

namespace ConsoleFramework.Designer
{
    public partial class Con
    {
        private const int ZIndexDefault = 10;
        public static int ZIndexCount = ZIndexDefault;
        public static int TickInterval { get; set; } = 600;
        private static LayerCollection Layers = null;
        private static Timer Tick;
        private static void InitialBuffer(Size size, int zIndexCount= ZIndexDefault)
        {
            ZIndexCount = zIndexCount;
            Size = size;
            Buffer = size;
            Layers = new LayerCollection();
            ClearLayers();
            Tick = new Timer{Interval=TickInterval};
            Tick.Tick+= TickOnTick;
            Tick.Enabled = true;
        }

        private static void TickOnTick(object sender, EventArgs e)
        {
            Layers.OnPaint();
        }

        /// <summary> Очистка графического буфера </summary>
        private static void ClearLayers()
        {
                Layers.Clear();
        }

        /// <summary> Дефолтное поле индекса графического буфера </summary>
        private static Char[,] DefaultLayer()
        {
            var ret = new Char[(int)Size.Width, (int)Size.Height];
            for (int y = 0; y < Size.Height; y++)
            for (int x = 0; x < Size.Width; x++)
                ret[x, y] = new Char();
            return ret;
        }

        private static void ResizeBuffer(Size size)
        {

        }


    }
}
