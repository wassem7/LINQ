public class DeferredExecution
{
    public static void main()
    {
        int[] numbers = { 1, 5, 2, 8, 9 };

        var words = new List<string>() { "wa", "da", "ccc" };


        var twoLetterOnly = words.Where(word => word.Length == 2);

        Console.WriteLine("FIRST ITERATION");
        foreach (var word in twoLetterOnly)
        {
            Console.Write(word);
            Console.WriteLine(" ");
        }
        Console.WriteLine("SECOND ITERATION");
        words.Add("fa");
        
        foreach (var word in twoLetterOnly)
        {
            Console.Write(word);
            Console.WriteLine(" ");
        }


    }
}