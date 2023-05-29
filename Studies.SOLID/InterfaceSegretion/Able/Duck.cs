namespace Studies.SOLID.InterfaceSegretion
{
    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }
}