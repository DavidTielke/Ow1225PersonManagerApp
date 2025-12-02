namespace ConsoleClient
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var command = new PersonDisplayCommand();
            command.DisplayAllAdults();
            command.DisplayAllChildren();
        }
    }

    public class PersonDisplayCommand
    {
        private PersonManager _personManager;

        public PersonDisplayCommand()
        {
            _personManager = new PersonManager();
        }

        public void DisplayAllAdults()
        {
            var adults = _personManager.GetAllAdults().ToList();
            Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine($"{a.Id}: {a.Name}, {a.Age} Jahre"));
        }

        public void DisplayAllChildren()
        {
            var children = _personManager.GetAllChildren().ToList();
            Console.WriteLine($"### Kinder ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine($"{c.Id}: {c.Name}, {c.Age} Jahre"));
        }
    }

    public class PersonManager
    {
        private readonly PersonRepository _personRepository;

        public PersonManager()
        {
            _personRepository = new PersonRepository();
        }
        public IQueryable<Person> GetAllAdults()
        {
            return _personRepository.Query().Where(p => p.Age >= 18);
        }

        public IQueryable<Person> GetAllChildren()
        {
            return _personRepository.Query().Where(p => p.Age < 18);
        }
    }

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
            var lines = _fileReader.ReadAllLines("persons.txt");
            var persons = lines.Select(line => _personParser.Parse(line));
            return persons.AsQueryable();
        }
    }

    public class FileReader
    {
        public IEnumerable<string> ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }

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
}
