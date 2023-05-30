namespace Studies.OperatorOverloading
{
    public class ComplexNumber
    {
        public int Integer { get; set; }
        public int Imaginary { get; set; }

        public ComplexNumber(int integer, int imaginary)
        {
            Integer = integer;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.Integer + obj2.Integer, obj1.Imaginary  + obj2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.Integer - obj2.Integer, obj1.Imaginary - obj2.Imaginary);
        }
    }
}
