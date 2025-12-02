using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace PersonManagement;

public class PersonManager
{
    private readonly PersonRepository _personRepository;

    public PersonManager()
    {
        _personRepository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _personRepository.Query().Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _personRepository.Query().Where(p => p.Age < 18);
    }
}