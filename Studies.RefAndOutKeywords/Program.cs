namespace Studies.RefAndOutKeywords
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Add(ref a, b);
            //a = 8
            int c;
            Multiply(a, b, out c);
            Console.WriteLine(a); //Output: 8
            //c = 24
            Console.WriteLine(c); //Output: 24
            Add(ref c, b);
            //c = 27
            Console.WriteLine(c); //Output: 27
        }

        static void Add(ref int x, int y)
        {
            x = x + y;
        }

        static void Multiply(int x, int y, out int r)
        {
            r = x * y;
        }
    }
}