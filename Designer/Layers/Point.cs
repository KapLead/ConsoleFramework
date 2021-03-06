namespace ConsoleFramework.Designer.Layers
{
    public struct Point
    {
        public short X;
        public short Y;

        public Point(short x = 0, short y = 0)
        {
            X = x;
            Y = y;
        }
        public Point(int x = 0, int y = 0)
        {
            X = (short)x;
            Y = (short)y;
        }
    }
}
