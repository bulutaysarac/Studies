namespace Studies.StaticReadonlyAndConstKeywords
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            Console.WriteLine("m._CreatedDate : " + m._createdTime);
            Thread.Sleep(1000);
            Math m2 = new Math();
            Console.WriteLine("m2._CreatedDate : " + m2._createdTime);
            m2.Dispose();
            Console.WriteLine("Instance Count : " + Math.InstanceCount);
            Console.WriteLine("3 + 2 = " + Math.Add(3, 2));
            Console.WriteLine("3 * 2 = " + m.Multiply(3, 2));
            Console.ReadLine();
        }
    }
}