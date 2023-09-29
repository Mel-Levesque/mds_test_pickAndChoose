using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Saisir une phrase: ");
        string text = Console.ReadLine();
        if (text != null)
        {
            Console.WriteLine(ConvertToUpper(text));
        }
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}