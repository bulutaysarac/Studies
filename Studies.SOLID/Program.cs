using Studies.SOLID.DependencyInversion;
using Studies.SOLID.LiskovsSubstitution;

namespace Studies.SOLID
{
    public class Program
    {
        /*
        S - Single Responsibility Principle
        O - Open Closed Principle
        L - Liskov's Substitution Principle
        I - Interface Segregation Principle
        D - Dependency Inversion Principle
        */

        static void Main(string[] args)
        {
            /*Liskov's Substitution*/
            Control textBox = new TextBox();
            textBox.Draw();
            //textBox.ClearText();

            /*Dependency Inversion*/
            IDatabase sqlDatabase = new SqlDatabase();
            DataService dataService = new DataService(sqlDatabase);
            dataService.SaveData("Sample data");
        }
    }
}