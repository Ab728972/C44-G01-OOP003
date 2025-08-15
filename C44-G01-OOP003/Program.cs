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
    }
}
