namespace Studies.OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(4, 7);
            ComplexNumber c3;

            c3 = c1 + c2;
            Console.WriteLine($"c1 = {c1.Integer} + {c1.Imaginary}i");
            Console.WriteLine($"c2 = {c2.Integer} + {c2.Imaginary}i");
            Console.WriteLine($"c1 + c2 = {c3.Integer} + {c3.Imaginary}i");
            c3 = c1 - c2;
            Console.WriteLine($"c1 - c2 = {c3.Integer} + {c3.Imaginary}i");
        }
    }
}