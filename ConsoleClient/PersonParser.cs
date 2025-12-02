namespace ConsoleClient;

public class PersonParser
{
    public Person Parse(string line)
    {
        var parts = line.Split(',');
        return new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
    }
}