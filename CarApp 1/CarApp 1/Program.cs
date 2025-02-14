using System;

class Program
{
    static void Main()
    {
        // Brugeren indtaster biloplysninger
        Console.WriteLine("Indtast bilmærke:");
        string bilModel = Console.ReadLine();

        Console.WriteLine("Indtast bilens årgang:");
        int bilÅrgang;

        while (!int.TryParse(Console.ReadLine(), out bilÅrgang))
        {
            Console.WriteLine("Fejl! Indtast venligst et gyldigt årstal:");
        }

        Console.WriteLine("Indtast brændstoftype:");
        string brændstofBeskrivelse = Console.ReadLine();

        // Formatér output med PadLeft og PadRight
        Console.WriteLine();
        Console.WriteLine("Biloplysninger:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Type bil".PadRight(20) + "Info om bil".PadLeft(20));
        Console.WriteLine("----------------------------");
        Console.WriteLine("Bilmærke:".PadRight(20) + bilModel.PadLeft(20));
        Console.WriteLine("Årgang:".PadRight(20) + bilÅrgang.ToString().PadLeft(20));
        Console.WriteLine("Brændstoftype:".PadRight(20) + brændstofBeskrivelse.PadLeft(20));
        Console.ReadLine();
    }
}


