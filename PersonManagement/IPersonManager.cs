using DavidTielke.PMA.CrossCutting.DataClasses;

namespace PersonManagement;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}