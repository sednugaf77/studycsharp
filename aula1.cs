public class Program
{
    public static void Main()
    {
        Random rng = new Random();
        int numRng = rng.Next(0,2);

        Console.WriteLine((numRng == 0)? "" : "");
    }
}