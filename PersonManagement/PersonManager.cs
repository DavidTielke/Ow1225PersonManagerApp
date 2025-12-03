using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _personRepository;

    public PersonManager(IPersonRepository personRepository)
    {
        _personRepository = personRepository;

        var repo = new PersonRepository(null, null);
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