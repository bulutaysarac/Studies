namespace Studies.SOLID.DependencyInversion
{
    public interface IDatabase
    {
        void Connect();
        void Disconnect();
        void InsertData(string data);
        void DeleteData(int id);
        //Other required methods...
    }
}