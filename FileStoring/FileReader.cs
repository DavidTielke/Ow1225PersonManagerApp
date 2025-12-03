using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.FileStoring;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadAllLines(string filePath)
    {
        return File.ReadAllLines(filePath);
    }
}