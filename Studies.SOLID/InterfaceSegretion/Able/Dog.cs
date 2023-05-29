namespace Studies.SOLID.InterfaceSegretion
{
    public class Dog : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("The dog is running.");
        }
    }
}