namespace LinqTutorial;

public class DefferedExecution1
{
    public static void main()
    {
        var persons = new List<Person>()
        {
            new Person() { Name = "Wassem", Country = "Canada" },
            new Person() { Name = "Darkwa", Country = "UAE" }
        };

        var personsInCanada = persons.Where(person => person.Country == "Canada");

        var allCanadians = personsInCanada.Take(5);

        foreach (var canadian in allCanadians)
        {
            Console.WriteLine($"Name : {canadian.Name}, Country : {canadian.Country}");
        }
    }
}
