
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using Microsoft.Extensions.DependencyInjection;
using PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();

            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
