﻿namespace LinqTutorial;

public class OfType
{
    public static void main()
    {
        IEnumerable<string> countries = new List<string>() { "Canada", "Usa" };

        var countriesString = countries.OfType<string>();
    }
}
