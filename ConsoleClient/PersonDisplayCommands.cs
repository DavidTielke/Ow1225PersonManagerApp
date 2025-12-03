using DavidTielke.PMA.Logic.PersonManagement.Contract;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    private IPersonManager _personManager;

    public PersonDisplayCommands(IPersonManager personManager)
    {
        _personManager = personManager;
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