namespace LinqTutorial;

public class MethodVsQuerySyntax
{
    public static void Main()
    {
        int[] numbers = new[] { 2, 2, 3, 5, 6, 7, 8, 9 };

        var oddNumberUsingExtensionMethod = numbers
            .Where(number => number < 10)
            .OrderBy(number => number)
            .Distinct();

        Console.WriteLine("Extension Method");
        Console.WriteLine(string.Join(",", oddNumberUsingExtensionMethod));

        var oddNumbersQuerySyntax = (
            from number in numbers
            where number < 10
            orderby number
            select number
        ).Distinct();

        Console.WriteLine("Query Syntax");
        Console.WriteLine(string.Join(",", oddNumbersQuerySyntax));
    }
}
