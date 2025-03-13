using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
//Car App. Seneste opdatering 21-02. Tilføjet menu, drive modul og loops. 

namespace Bil_app__første_lektion
{
    public class car
    {
        public string make;
        public string model;
        public int year;
        public int mileage;
        public double econ;
        public string carFuelInput;
    }
    public class trip
    {
        public bool isEngineOn;
        public char isEngineOnResponse;
        public int tripDistance;
        public double fuelSpent;
    }
    public enum FuelType
    {
        Benzin,
        Diesel,
        El
    }
    //Static variabler - så de kan bruges tværs over metoderne:

    internal class Program
    {
        static int mainMenuQuery = 1;
        static int readCarMenu1;
        static int readCarMenu2;
        static int readCarDetailsChoice;
        static int continueQuery;
        static int continueQuery2;
        static int continueQuery3;

        static bool isCar1EngineOn;
        static char engineResponse1;
        //readCarDetails metode. Bruger indtaster ønskede bil og switch gemmer herefter i den korrekte variabel. 

        static void readCarDetails()
        {
            //Løkke initialiseres - brugeren angiver efter indtastning af 1 bil, om flere skal indtastes. 
            do

            {

                //Bruger vælger at indtaste en ny bil - vælges nej, termi

                Console.WriteLine("\n\n------ Modul til indtastning af oplysninger om bil ------");
                Console.WriteLine("\t-¨Udfyld venligst alle de angivede oplysninger forneden.");

                int.TryParse(Console.ReadLine(), out readCarDetailsChoice);

                // Bruger indtaster for bil. Oplysninger gemmes i en list<t> og kan hentes frem senere.

                Console.WriteLine("\nDu indtaster nu data for bil nr. 1");

                        Console.WriteLine("Indtast fabrikanten");

                        carMake = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car1Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car1Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car1Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out carFuelInput);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car1Econ);

                //Do while løkke - ønsker bruger at fortsætte med at indtaste flere biler? Hvis ja, koden køres igen. 

                Console.WriteLine("Ønsker du at indtaste en bil mere? Tast 1 for 'Ja' eller hvilken som helst anden tast for 'Nej'. Andre input vil afslutte operationen.");
                int.TryParse(Console.ReadLine(), out continueQuery);
            }

            // Hvis indtastet 1, koden køres igen

            while (continueQuery == 1);
        }

        //Trip modul. Brugeren kører en simuleret tur i sin bil og får ved turens afslutning en aflæsning af resultatet. 
        static void readTripModule()
        {

            int menuChoice4;
            int loopRepeat1;

            do
            {

                Console.WriteLine("\n------ Trip Modul ------");

                //Brugeren vælger den bil som de har indtastet i modul 1

                Console.WriteLine("\n");

                int.TryParse(Console.ReadLine(), out menuChoice4);

                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse1);
                        if (engineResponse1 == 'J')
                        {
                            isCar1EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar1EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car1Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car1Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car1Mileage, car1Mileage + car1Trip);

                            }
                        }
                        else if (engineResponse1 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                Console.WriteLine("\n\t - Du beregnede nu turen for en bil og dens kilometerstand blev opdateret.\n\n\tKør en tur med en anden bil nu? Tast '1' for Ja. Ellers tryk hvilken som helst anden tast");
                int.TryParse(Console.ReadLine(), out loopRepeat1);
            }

            while (loopRepeat1 == 1) ;
        }

            static void readTripEconomy()
        {
            Console.WriteLine("------ Trip Economy Modul ------");
        }
        static void readPalindrome()
        {
            Console.WriteLine("------ Palindrom-Check Modul ------");
        }
        static void readCarSingularData()
        {
            int readCarMenu3;
            int menuChoice3;

            Console.WriteLine("\n------ Detaljer Om Enkelt Bil Modul ------");
            Console.WriteLine("\n\t- Vælg en bil ved at taste et tal mellem 1 og 6:");

            int.TryParse(Console.ReadLine(), out readCarMenu3);

            do
            {
                switch (readCarMenu3)
                {
                    case 1:
                        car1();
                        break;
                    default:
                        Console.WriteLine("Ugyldig bil indtastet. Prøv igen. Vælge en bil mellem 1 og 6.");
                        break;
                }

                Console.WriteLine("\n\nVil du se data for en bil mere? Tast '1'.\n\nHvis ikke, tryk på en hvilken som helst anden tast for at vende retur til hovedmenuen");
                int.TryParse(Console.ReadLine(), out menuChoice3);
            }

            while (menuChoice3 == 1) ;
            
        }

        static void readCarTotalData()
        {
            Console.WriteLine("------ Detaljer Om Alle Biler Modul ------\n\n");


            Console.WriteLine("\n\nTryk på en vilkårlig tast for at hente hovedmenuen");

            Console.ReadKey();
        }

        //Følgende 6 metoder indeholder oplysninger om hver respektive bil

        static void car6()
        {
            Console.WriteLine("------ Grundoplysninger om bilen ------\n");
            Console.WriteLine("Mærke: {0}", carMake);
            Console.WriteLine("Model: {0}", carModel);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car6Year, car6Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", carEcon);
            Console.WriteLine("Drivmidlet er {0}", carEcon);
        }

        //Velkomst til programmet og menupunkt initialiseres

        static void Main(string[] args)
        {
            do
            {

                int menuChoice;

                //Variabel til at bestemme brugerinput

                Console.WriteLine("------ Velkommen til CarApp version 1.01\n\nVælg den ønskede funktion i menuen for neden: ------\n\n");
                Console.WriteLine("\t- Tast '1' for at indlæse biloplysninger.\n\n\t- Tast '2' for at starte \"Drive\" modulet.\n\n\t- Tast '3' for at beregne tur-økonomi.\n\n\t- Tast '4' for at åbne Palindrom-tjek\n\n\t- Tast '5' for at se detaljer om enkelt bil.\n\n\t- Tast '6' for at se detaljer om alle biler.");

                //Brugeren indtaster sit menuvalg 

                int.TryParse(Console.ReadLine(), out menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        {
                            readCarDetails();
                        }
                        break;
                    case 2:
                        {
                            readTripModule();
                        }
                        break;
                    case 3:
                        {
                            readTripEconomy();
                        }
                        break;
                    case 4:
                        {
                            readPalindrome();
                        }
                        break;
                    case 5:
                        {
                            readCarSingularData();
                        }
                        break;
                    case 6:
                        {
                            readCarTotalData();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("FEJL. Du har tastet ugyldigt input");
                        }
                        break;
                }
            }
            while (mainMenuQuery == 1);
        }
    }
}

