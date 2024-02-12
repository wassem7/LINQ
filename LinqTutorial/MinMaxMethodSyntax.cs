namespace LinqTutorial;

public class MinMaxMethodSyntax
{
    public static void Main()
    {
        int[] numbers = new[] { 1, 4, 5, 9, 2 };
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

        var smallestSalary = persons.Min(person => person.Salary);
        var largestSalary = persons.Max(person => person.Salary);
        var smallestNumber = numbers.Min();

        Console.WriteLine($"Smallest Salary : {smallestSalary}");

        Console.WriteLine($"Largest Salary : {largestSalary}");
    }
}
