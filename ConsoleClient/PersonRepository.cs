using ConsoleClient.DataClasses;

namespace ConsoleClient;

public class PersonRepository
{
    private readonly PersonParser _personParser;
    private readonly FileReader _fileReader;

    public PersonRepository()
    {
        _personParser = new PersonParser();
        _fileReader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var lines = _fileReader.ReadAllLines("data.csv");
        var persons = lines.Select(line => _personParser.Parse(line));
        return persons.AsQueryable();
    }
}