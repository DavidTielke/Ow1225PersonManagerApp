namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = new PersonDisplayCommand();
            command.DisplayAllAdults();
            command.DisplayAllChildren();
        }
    }
}
