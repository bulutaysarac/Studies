namespace Studies.SOLID.InterfaceSegretion
{
    public class Kangaroo : IJumpable, IRunnable
    {
        public void Jump()
        {
            Console.WriteLine("The kangaroo is jumping.");
        }

        public void Run()
        {
            Console.WriteLine("The kangaroo is running.");
        }
    }
}