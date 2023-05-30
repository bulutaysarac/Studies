namespace Studies.Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart[0] = "Apple";
            cart[1] = "Tomato";

            string firstItem = cart[0];

            Console.WriteLine(firstItem);
        }
    }
}