namespace LinqTutorial;

public class AverageMethodSyntax
{
    public static void main()
    {
        int[] numbers = new[] { 1, 5, 3, 2, 9 };

        var average = numbers.Average();
        var persons = new[]
        {
            new Person()
            {
                Name = "Wassem",
                Country = "Canada",
                Salary = 100000
            },
            new Person()
            {
                Name = "Seemzy",
                Country = "USA",
                Salary = 300
            },
            new Person()
            {
                Name = "Darkwa",
                Country = "Canada",
                Salary = 500
            }
        };

        IEnumerable<string> countries = new List<string>() { "Canada", "Usa" };
        var firstCountry = countries.ElementAtOrDefault(0);
        var averageSalary = persons.Average(person => person.Salary);

        var salarySum = persons.Sum(person => person.Salary);

        Console.WriteLine($"Salary Sum : {salarySum}");
        Console.WriteLine($"Average Salary : ${averageSalary}");
        Console.WriteLine($"Number Average : {average}");
    }
}
