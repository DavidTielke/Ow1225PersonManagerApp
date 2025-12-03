using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using Microsoft.Extensions.DependencyInjection;
using PersonManagement;

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
        }
    }
}
