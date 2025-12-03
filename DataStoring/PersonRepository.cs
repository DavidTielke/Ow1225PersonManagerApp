using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _personParser;
    private readonly IFileReader _fileReader;

    public PersonRepository(IPersonParser personParser, IFileReader fileReader)
    {
        _personParser = personParser;
        _fileReader = fileReader;
    }

    public IQueryable<Person> Query()
    {
        var lines = _fileReader.ReadAllLines("data.csv");
        var persons = lines.Select(line => _personParser.Parse(line));
        return persons.AsQueryable();
    }
}