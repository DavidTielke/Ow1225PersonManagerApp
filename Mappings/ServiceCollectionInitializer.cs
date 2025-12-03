using Configuration;
using Configuration.Contract;
using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Data.FileStoring.Contract;
using DavidTielke.PMA.Logic.PersonManagement;
using DavidTielke.PMA.Logic.PersonManagement.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection collection)
        {
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();
            collection.AddSingleton<IConfigurator, Configurator>();
        }
    }
}
