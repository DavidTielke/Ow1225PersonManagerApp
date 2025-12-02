namespace DavidTielke.PMA.Data.FileStoring;

public class FileReader
{
    public IEnumerable<string> ReadAllLines(string filePath)
    {
        return File.ReadAllLines(filePath);
    }
}