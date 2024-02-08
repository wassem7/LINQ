namespace LinqTutorial;

public class DeferredExecution2
{
    public static void main()
    {
        var animals = new List<string>() { "Dog", "Cow", "Dolphin" };

        var animalsStartingWithD = animals.Where(animal =>
        {
            Console.WriteLine("-- checking : {0} --", animal);
            return animal.ToLower().StartsWith('d');
        });

        foreach (var animal in animalsStartingWithD)
        {
            Console.Write(animal);
            Console.WriteLine();
        }
    }
}
