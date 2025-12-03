using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring.Contract;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}