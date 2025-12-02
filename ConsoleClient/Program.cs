namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = new PersonDisplayCommands();
            command.DisplayAllAdults();
            command.DisplayAllChildren();
        }
    }
}
