using ConsoleFramework.Designer.Layers;

namespace ConsoleFramework.Frame
{
    public class View
    {
        public Size Size { get; set; }

        private View _owner;
        public View(View owner)
        {
            _owner = owner;
        }
    }
}
