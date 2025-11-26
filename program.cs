using System;

public class Program
{
    public static void Main()
    {       
        Random rnd = new Random();
        int numRnd = rnd.Next(0,101);

        Console.WriteLine($"Resultado {(numRnd <=50? 'Tails':'Heads')}");

    }
}
