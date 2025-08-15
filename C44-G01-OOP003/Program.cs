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
        #region Q3 - Complex Number Class
        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
                => new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);

            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
                => new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        #endregion
        #region Q4 - Employee and Manager Classes
        public class Employee
        {
            public virtual void Work() => Console.WriteLine("Employee is working");
        }

        public class Manager : Employee
        {
            public override void Work()
            {
                base.Work();
                Console.WriteLine("Manager is managing");
            }
        }
        #endregion
        #region Q5 - BaseClass and Derived Classes
        public class BaseClass
        {
            public virtual void DisplayMessage() => Console.WriteLine("Message from BaseClass");
        }

        public class DerivedClass1 : BaseClass
        {
            public override void DisplayMessage() => Console.WriteLine("Message from DerivedClass1");
        }

        public class DerivedClass2 : BaseClass
        {
            public new void DisplayMessage() => Console.WriteLine("Message from DerivedClass2");
        }

        /*
        Difference between override and new:
        - override: Runtime polymorphism (late binding). The derived method completely replaces the base method.
        - new: Compile-time polymorphism (early binding). The base method is hidden but still exists.
        */
        #endregion
    }
}
