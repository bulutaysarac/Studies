namespace Studies.SOLID.DependencyInversion
{
    public class SqlDatabase : IDatabase
    {
        public void Connect()
        {
            //SQL database connection operations.
        }

        public void Disconnect()
        {
            //SQL database disconnect operations.
        }

        public void InsertData(string data)
        {
            //Data insertion operations.
        }

        public void DeleteData(int id)
        {
            //Data deletion operations.
        }
        //Other required methods...
    }
}