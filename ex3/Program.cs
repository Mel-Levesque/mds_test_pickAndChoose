using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        //int int nb = Console.ReadLine();
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Nombre pair");
            }
            else
            {
                Console.WriteLine("Nombre impair");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}
