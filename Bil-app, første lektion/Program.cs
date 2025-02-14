using Microsoft.VisualBasic.FileIO;

namespace Bil_app__første_lektion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definér variable
            string bilModel;
            int bilÅrgang;
            char bilGearkasse;
            char bilBrændstof;
            double bilForbrug;
            double brændstofPris;
            double brændstofNødvendigt;
            double pengeNødvendigt;
            int bilKilometerstand;
            int turDistance;
            int kilometerstandEfter;
            string gearBeskrivelse;
            string brændstofBeskrivelse;

            // Start af program
            Console.WriteLine("Velkommen til CarApp version 1.0\n");

            // Spørg om fabrikant af bil
            Console.WriteLine("Hvilken fabrikant har lavet din bil?:");
            string bilFabrikant = Console.ReadLine();

            // Spørg om model på bil
            Console.WriteLine("Hvilken model er din bil?");
            bilModel = Console.ReadLine();

            // Spørg om kilometer kørt på bilen
            Console.WriteLine("Hvor mange kilometer har bilen kørt?:");
            bilKilometerstand = Convert.ToInt32(Console.ReadLine());

            // Spørg om brændstofstype
            Console.WriteLine("Hvilket slags brændstof bruger den? B for benzin, D for diesel");
            bilBrændstof = Console.ReadLine()[0];

            // Spørg om kilometer/literen
            Console.WriteLine("Hvor langt kører den på literen? (Angiv i km/l.):");
            bilForbrug = Convert.ToDouble(Console.ReadLine());

            // Spørg om årgang på bilen
            Console.WriteLine("Hvad årgang er din bil?");
            bilÅrgang = Convert.ToInt32(Console.ReadLine());

            // Spørg om geartype
            Console.WriteLine("Er bilens gear manuelt eller automatisk? Tast A for auto, M for manuel.");
            bilGearkasse = Console.ReadLine()[0];

            // Definér geartype og brændstof ud fra char
            gearBeskrivelse = bilGearkasse == 'A' ? "automatgear" : (bilGearkasse == 'M' ? "manuelt gear" : "ukendt, du har tastet forkert input");
            brændstofBeskrivelse = bilBrændstof == 'B' ? "benzin" : (bilBrændstof == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

            Console.WriteLine("Tak for det indtastede! Vi ved nu at din bil er produceret af " + bilFabrikant + " og er af modellen " + bilModel + " - den er fra år " + bilÅrgang + " og gearkassen er " + gearBeskrivelse + ". Den anvender " + brændstofBeskrivelse + " som drivmiddel, kører " + bilForbrug + " pr. liter " + brændstofBeskrivelse + " og har tilbagelagt i alt " + bilKilometerstand + " kilometer siden den var ny.\n\nDer skal nu beregnes på økonomien i en tur.");

            // Udregn
            Console.WriteLine("\n\nIndtast venligst gældende pris for en liter brændstof:");
            brændstofPris = Convert.ToDouble(Console.ReadLine());

            // Spørg om længde på tur
            Console.WriteLine("Angiv, hvor lang en tur du skal ud og køre - brug ikke decimaler:");
            turDistance = Convert.ToInt32(Console.ReadLine());

            // Udregn brændstofsforbrug, kostpris og kilometerstand
            brændstofNødvendigt = turDistance / bilForbrug;
            pengeNødvendigt = brændstofNødvendigt * brændstofPris;
            kilometerstandEfter = Convert.ToInt32(bilKilometerstand + turDistance);
            
            Console.WriteLine("\nTil den pågældende tur behøver du {0} liter brændstof\n\t- det vil koste dig {1} kroner i brændstofudgifter!", brændstofNødvendigt, pengeNødvendigt);
            Console.WriteLine("\nFør turen bliver kørt har din bil tilbagelagt {0} kilometer. Efter køreturen vil den have tilbagelagt {1} kilometer!", bilKilometerstand, kilometerstandEfter);
            Console.ReadLine();

        }
    }
}
