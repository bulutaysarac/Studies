namespace Studies.SOLID.DependencyInversion
{
    /*
     Now, we can use the DataService class to perform database operations. This class performs database operations through an IDatabase object. By inverting the dependency, when we want to switch to a different database service implementation, we can simply create another class that implements the IDatabase interface and inject that class into DataService.
     */

    public class DataService
    {
        private readonly IDatabase _database;

        public DataService(IDatabase database)
        {
            _database = database;
        }

        public void SaveData(string data)
        {
            _database.Connect();
            _database.InsertData(data);
            _database.Disconnect();
        }

        public void DeleteData(int id)
        {
            _database.Connect();
            _database.DeleteData(id);
            _database.Disconnect();
        }
        //Other required methods...
    }
}