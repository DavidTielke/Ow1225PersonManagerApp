namespace DavidTielke.PMA.Data.FileStoring.Contract;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string filePath);
}