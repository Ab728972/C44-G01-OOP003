namespace C44_G01_OOP003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        #region Q1 - Calculator Class
        public class Calculator
        {
            public int Add(int a, int b) => a + b;
            public int Add(int a, int b, int c) => a + b + c;
            public double Add(double a, double b) => a + b;
        }
        #endregion
        #region Q2 - Rectangle Class
        public class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle() : this(0, 0) { }
            public Rectangle(int size) : this(size, size) { }
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }
        #endregion
    }
}
