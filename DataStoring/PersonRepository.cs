using Configuration.Contract;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _personParser;
    private readonly IFileReader _fileReader;
    private readonly string CsvPath;

    public PersonRepository(IPersonParser personParser, 
        IFileReader fileReader, IConfigurator config)
    {
        CsvPath = config.Get<string>("FileStoring", "CsvPath");
        _personParser = personParser;
        _fileReader = fileReader;
    }

    public IQueryable<Person> Query()
    {
        var lines = _fileReader.ReadAllLines(CsvPath);
        var persons = lines.Select(line => _personParser.Parse(line));
        return persons.AsQueryable();
    }
}