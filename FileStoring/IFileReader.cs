namespace DavidTielke.PMA.Data.FileStoring;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string filePath);
}