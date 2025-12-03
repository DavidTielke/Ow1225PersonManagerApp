using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonParser : IPersonParser
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