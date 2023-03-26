namespace ObjectOrientedPatterns.Structural
{
    public interface IDrawingApi
    {
        public void DrawCircle(double x, double y, double radius);
        public void Render();
    }

    public class WindowsDrawingApi : IDrawingApi
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("Windows circle at ({0}{1}) with radius {2}", x, y, radius);
        }

        public void Render()
        {
            Console.WriteLine("calling Windows system calls to show it on screen");
        }
    }
    public class LinuxDrawingApi : IDrawingApi
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("Linux circle at ({0}{1}) with radius {2}", x, y, radius);
        }

        public void Render()
        {
            Console.WriteLine("calling Linux system calls to show it on screen");
        }
    }

    public abstract class Shape
    {
        public Shape(IDrawingApi drawingApi)
        {
            myDrawingApi = drawingApi;
        }

        abstract public void Draw();

        public IDrawingApi myDrawingApi;
    }

    public class Circle : Shape
    {
        public Circle(IDrawingApi drawingApi, double radius, double x, double y) : base(drawingApi)
        {
            myRadius = radius;
            myX = x;
            myY = y;
        }

        public override void Draw()
        {
            myDrawingApi.DrawCircle(myX, myY, myRadius);
            myDrawingApi.Render();
        }

        private double myRadius;
        private double myX;
        private double myY;
    }
}
