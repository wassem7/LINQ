namespace LinqTutorial;

public class PrependAppendMethodSyntax
{
    public static void Main()
    {
        IEnumerable<string> countries = new List<string>() { "Canada", "Usa" };

        var countriesPrepend = countries.Prepend("Ghana");

        var countriesAppend = countries.Append("Denmark");
    }
}
