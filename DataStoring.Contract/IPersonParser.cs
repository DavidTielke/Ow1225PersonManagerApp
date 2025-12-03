using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring.Contract;

public interface IPersonParser
{
    Person Parse(string line);
}