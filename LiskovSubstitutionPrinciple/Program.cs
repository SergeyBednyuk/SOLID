namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartApp(new MySqlDataBase());
            StartApp(new MongoDataBase());

            Console.WriteLine("Hello, World!");
        }


        public static void StartApp(DataBase dataBase)
        {
            dataBase.Connect();
        }
    }
}