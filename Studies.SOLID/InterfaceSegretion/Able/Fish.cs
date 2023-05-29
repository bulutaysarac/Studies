namespace Studies.SOLID.InterfaceSegretion
{
    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("The fish is swimming.");
        }
    }
}