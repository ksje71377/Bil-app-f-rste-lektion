using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
//Kennies Private Spor, branch af master fra UCL CarApp. Tilføjet i dette commit: variabler er flyttet til klassen carAppInfo da de skal kunne hentes fra en metode.
namespace Bil_app__første_lektion
{
    internal class Program
    {
        public class carAppInfo
        //Variabler hentes fra metoden, en klasse er oprettet da variabler ellers kun kan eksistere i den metode som de er skrevet i. 
        {
            public string bilModel;
            public int bilÅrgang;
            public char bilGearkasse;
            public char bilBrændstof;
            public double bilForbrug;
            public double brændstofPris;
            public double brændstofNødvendigt;
            public double pengeNødvendigt;
            public int bilKilometerstand;
            public int turDistance;
            public int kilometerstandEfter;
            public string gearBeskrivelse;
            public string brændstofBeskrivelse;
        }

        //Start på programmet

        static void Main(string[] args)
        {
            //Metoden carAppInfo (indeholdende variablerne) kaldes:

            carAppInfo carAppInfo = new carAppInfo();

            //Velkomstbesked

            Console.WriteLine("Velkommen til CarApp version 1.01\n\nVælg venligst en funktion forneden i hovedmenuen.\n\n");

            //Hovedmenu

            Console.WriteLine("Tast '1' for at indtaste oplysninger om et nyt køretøj.\tTast '2' for at åbne \"Drive\" modulet.\n\nTast '3' for at beregne brændstoføkonomi på en tur\tTast '4' for at åbne \"Palindrom\"-tjek.\n\nTast '5' for at vise aktuelle bil data.\t\t\tTast '6' for se alle teamets bilinformationer.");

            //Case statement skal følge som afhænger af brugerens input - indhent variabel menuValg
            int menuValg;
            int.TryParse (Console.ReadLine(), out menuValg);

            switch (menuValg)
            {
                case 1:
                    //Indhent metode indtast bilinfo (skal være do-while loop, fordi, mindst en bil er påkrævet, vi kender ikke øvre antal af biler som skal indtastes
                    break;
                case 2:
                    //Indhent metode drive modul
                    break;
                case 3:
                    //Indhent metode tripEconomy
                    break;
                case 4:
                    //Indhent metode palindrom
                    break;
                case 5:
                    //Indhent metode vis aktuel bildata
                    break;
                case 6:
                    //Vis alle teamets bilinformationer 
                    break;
                default:
                    Console.WriteLine("FEJL. Du har indtastet et UGYLDIGT valg. Prøv igen, eller afslut programmet.");
                    break;

            }

            //Flere biler (med "samme" variabel") kan lade sig gøre med et loop. 

            Console.ReadKey();
        }
    }
}