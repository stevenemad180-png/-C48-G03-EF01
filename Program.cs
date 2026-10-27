namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new ProgramContext();


            Console.WriteLine(
                db.Database.CanConnect()
                    ? "Database Connected Successfully"
                    : "Database Connection Failed"
            );
        }
    }
}
