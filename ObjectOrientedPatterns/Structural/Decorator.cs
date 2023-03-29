namespace ObjectOrientedPatterns.Structural.Decorator
{
    // see https://en.wikipedia.org/wiki/Decorator_pattern

    public interface IWindow
    {
        public void Draw();
    }

    public class NormalWindow : IWindow
    {
        public void Draw() => Console.WriteLine("A normal window");
    }

    public class WindowDecorator : IWindow
    {
        public WindowDecorator(IWindow window)
        {
            myWindow = window;
        }
        public virtual void Draw() => myWindow.Draw();
        private IWindow myWindow;
    }

    public class VerticalScrollbarDecorator : WindowDecorator
    {
        public VerticalScrollbarDecorator(IWindow window) : base(window) { }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("  with a vertical scroll bar");
        }
    }

    public class MenuBarDecorator : WindowDecorator
    {
        public MenuBarDecorator(IWindow window) : base(window) { }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("  with a menu bar");
        }
    }
}
