namespace Studies.StaticReadonlyAndConstKeywords
{
    public class Math : IDisposable
    {
        //A static property that can not be set out of class but readable.
        public static int InstanceCount { get; private set; } = 0;

        //Constant variables that assigned at compiletime that can not be changed at runtime. Only primitive types can be const.
        public const double PI = 3.14;
        public const double E = 2.71;
        //Readonly variable that will be unchangeable when it gets assigned once.
        public readonly DateTime _createdTime;

        //Constructor
        public Math()
        {
            InstanceCount++;
            _createdTime = DateTime.Now;
        }

        //A static method that can be accessed with class name. Instance is NOT required.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //A normal method that can NOT be accessed with class name. Instance required.
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Dispose()
        {
            InstanceCount--;
            GC.SuppressFinalize(this);
            Console.WriteLine("Object disposed!");
        }
    }
}