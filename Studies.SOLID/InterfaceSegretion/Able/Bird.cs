namespace Studies.SOLID.InterfaceSegretion
{
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }
}