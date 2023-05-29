namespace Studies.AbstractClassesAndInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            mercedes.Accelerate();
            mercedes.Accelerate();
            Console.WriteLine(mercedes.CurrentSpeed);
            mercedes.Deaccelerate();
            Console.WriteLine(mercedes.CurrentSpeed);
            Console.ReadLine();
        }
    }
}