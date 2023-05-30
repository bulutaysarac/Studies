namespace Studies.Indexers
{
    public class ShoppingCart
    {
        private List<string> items = new List<string>();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Count)
                    return items[index];

                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < items.Count)
                    items[index] = value;
                else if (index == items.Count)
                    items.Add(value);
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}
