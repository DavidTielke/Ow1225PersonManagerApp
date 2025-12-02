namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonValidator
{

}

public class PersonDisplayCommands
{
    private PersonManager _personManager;

    public PersonDisplayCommands()
    {
        _personManager = new PersonManager();
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults().ToList();
        Console.WriteLine($"## Erwachsene ({adults.Count}) ##");
        adults.ForEach(a => Console.WriteLine($"{a.Id}: {a.Name}, {a.Age} Jahre"));
    }

    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren().ToList();
        Console.WriteLine($"## Kinder ({children.Count}) ##");
        children.ForEach(c => Console.WriteLine($"{c.Id}: {c.Name}, {c.Age} Jahre"));
    }
}