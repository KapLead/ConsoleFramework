namespace ConsoleFramework.Designer.Layers
{
    public struct Size
    {
        public short Width;
        public short Height;

        public Size(short w = 0, short h = 0)
        {
            Width = w;
            Height = h;
        }
        public Size(int w = 0, int h = 0)
        {
            Width = (short)w;
            Height= (short)h;
        }
    }
}
