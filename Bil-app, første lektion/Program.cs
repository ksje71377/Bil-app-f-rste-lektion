using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
//Car App. Seneste opdatering 21-02. Tilføjet menu, drive modul og loops. 

namespace Bil_app__første_lektion
{
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
        static bool isCar2EngineOn;
        static char engineResponse2;
        static bool isCar3EngineOn;
        static char engineResponse3;
        static bool isCar4EngineOn;
        static char engineResponse4;
        static bool isCar5EngineOn;
        static char engineResponse5;
        static bool isCar6EngineOn;
        static char engineResponse6;

        static string car1Make;
        static string car1Model;
        static int car1Year;
        static int car1Mileage;
        static double car1Econ;
        static char car1FuelType;
        static string car1FuelDescription = car1FuelType == 'B' ? "benzin" : (car1FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static string car2Make;
        static string car2Model;
        static int car2Year;
        static int car2Mileage;
        static double car2Econ;
        static char car2FuelType;
        static string car2FuelDescription = car2FuelType == 'B' ? "benzin" : (car2FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static string car3Make;
        static string car3Model;
        static int car3Year;
        static int car3Mileage;
        static double car3Econ;
        static char car3FuelType;
        static string car3FuelDescription = car3FuelType == 'B' ? "benzin" : (car3FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static string car4Make;
        static string car4Model;
        static int car4Year;
        static int car4Mileage;
        static double car4Econ;
        static char car4FuelType;
        static string car4FuelDescription = car4FuelType == 'B' ? "benzin" : (car4FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static string car5Make;
        static string car5Model;
        static int car5Year;
        static int car5Mileage;
        static double car5Econ;
        static char car5FuelType;
        static string car5FuelDescription = car5FuelType == 'B' ? "benzin" : (car5FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static string car6Make;
        static string car6Model;
        static int car6Year;
        static int car6Mileage;
        static double car6Econ;
        static char car6FuelType;
        static string car6FuelDescription = car6FuelType == 'B' ? "benzin" : (car6FuelType == 'D' ? "diesel" : "ukendt brændstoftype, du har tastet forkert input");

        static int car1Trip;
        static int car2Trip;
        static int car3Trip;
        static int car4Trip;
        static int car5Trip;
        static int car6Trip;

        static double car1FuelSpent;
        static double car2FuelSpent;
        static double car3FuelSpent;
        static double car4FuelSpent;
        static double car5FuelSpent;
        static double car6FuelSpent;

        //readCarDetails metode. Bruger indtaster ønskede bil og switch gemmer herefter i den korrekte variabel. 

        static void readCarDetails()
        {
            //Løkke initialiseres - brugeren angiver efter indtastning af 1 bil, om flere skal indtastes. 
            do

            {

                //Bruger vælger mellem bil nr. 1 til 6 gennem undermenuen:

                Console.WriteLine("\n\n------ Modul til indtastning af oplysninger om bil ------");
                Console.WriteLine("\t- Vælg mellem bil nr. 1 til og med 6. ved at indtaste tallet for den ønskede bil forneden:");

                int.TryParse(Console.ReadLine(), out readCarDetailsChoice);

                // Bruger indtaster for bil nr 1 og gemmer det i variablen

                switch (readCarDetailsChoice)
                {
                    case 1:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 1");

                        Console.WriteLine("Indtast fabrikanten");

                        car1Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car1Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car1Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car1Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car1FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car1Econ);

                        break;

                    // Bruger indtaster for bil nr 2 og gemmer det i variablen

                    case 2:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 2");

                        Console.WriteLine("Indtast fabrikanten");

                        car2Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car2Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car2Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car2Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car2FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car2Econ);

                        break;

                    // Bruger indtaster for bil nr 3 og gemmer det i variablen

                    case 3:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 3");

                        Console.WriteLine("Indtast fabrikanten");

                        car3Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car3Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car3Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car3Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car3FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car3Econ);

                        break;

                    // Bruger indtaster for bil nr 4 og gemmer det i variablen

                    case 4:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 4");

                        Console.WriteLine("Indtast fabrikanten");

                        car4Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car4Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car4Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car4Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car4FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car4Econ);

                        break;

                    // Bruger indtaster for bil nr 5 og gemmer det i variablen

                    case 5:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 5");

                        Console.WriteLine("Indtast fabrikanten");

                        car5Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car5Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car5Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car5Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car5FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car5Econ);

                        break;

                    // Bruger indtaster for bil nr 6 og gemmer det i variablen

                    case 6:
                        Console.WriteLine("\nDu indtaster nu data for bil nr. 6");

                        Console.WriteLine("Indtast fabrikanten");

                        car6Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car6Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car6Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car6Mileage);

                        Console.WriteLine("Angiv drivmiddel-type. Benzin angives 'B', diesel 'D' og el 'E'.");

                        Char.TryParse(Console.ReadLine(), out car6FuelType);

                        Console.WriteLine("Indtast bilens forbrug i km/l:");

                        double.TryParse(Console.ReadLine(), out car6Econ);

                        break;

                    default:
                        {
                            Console.WriteLine("FEJL. Du har tastet ugyldigt input");
                        }
                        break;
                }

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

                Console.WriteLine("\nVælg en bil ved at taste et tal mellem 1 og 6:");

                int.TryParse(Console.ReadLine(), out menuChoice4);

                switch (menuChoice4)
                {
                    case 1:
                        Console.WriteLine("\nDu har valgt bil 1.");
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
                        break;

                    case 2:
                        Console.WriteLine("\nDu har valgt bil 2.");
                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse2);
                        if (engineResponse2 == 'J')
                        {
                            isCar2EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar2EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car2Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car2Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car2Mileage, car2Mileage + car2Trip);

                            }
                        }
                        else if (engineResponse2 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                        break;


                    case 3:
                        Console.WriteLine("\nDu har valgt bil 3.");
                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse3);
                        if (engineResponse3 == 'J')
                        {
                            isCar3EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar1EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car3Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car3Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car3Mileage, car3Mileage + car3Trip);

                            }
                        }
                        else if (engineResponse3 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                        break;


                    case 4:
                        Console.WriteLine("\nDu har valgt bil 4.");
                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse4);
                        if (engineResponse4 == 'J')
                        {
                            isCar4EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar4EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car1Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car4Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car4Mileage, car4Mileage + car4Trip);

                            }
                        }
                        else if (engineResponse5 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                        break;


                    case 5:
                        Console.WriteLine("\nDu har valgt bil 5.");
                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse5);
                        if (engineResponse5 == 'J')
                        {
                            isCar5EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar5EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car5Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car5Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car5Mileage, car5Mileage + car5Trip);

                            }
                        }
                        else if (engineResponse5 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                        break;


                    case 6:
                        Console.WriteLine("\nDu har valgt bil 6.");
                        Console.WriteLine("\t- For at køre nogle steder, er det nødvendigt at starte motoren. Vil du gøre det nu? Indtast 'J' for ja, 'N' for nej.");
                        char.TryParse(Console.ReadLine(), out engineResponse6);
                        if (engineResponse6 == 'J')
                        {
                            isCar1EngineOn = true;

                            Console.WriteLine("\nMotoren er nu tændt.");

                            if (isCar6EngineOn == true)
                            {
                                Console.WriteLine("\nHvor langt skal du ud og køre? Angiv i km. Decimaltal ikke tilladt.");

                                int.TryParse(Console.ReadLine(), out car6Trip);

                                Console.WriteLine("\n\nTuren er nu undervejs...\n\n\t*** Tast en vilkårlig tast for at afslutte turen og aflæse resultatet!***");
                                Console.WriteLine("\nBilen tilbagelagte {0} kilometer på denne køretur.", car6Trip);
                                Console.WriteLine("\nBilens oprindelige kilometerstand var {0}, men er efter turen {1}.", car6Mileage, car6Mileage + car6Trip);

                            }
                        }
                        else if (engineResponse6 == 'N')
                        {
                            Console.WriteLine("\t***FEJL***\n\nDu kan ikke køre uden en tændt motor. Overvej lige en ekstra gang, om ikke at du vil tænde motoren på bilen.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUgyldigt valg. Prøv igen. Bogstaver skal skrives med stort.");
                        }
                        break;


                    default:
                        Console.WriteLine("Ugyldig bil indtastet. Prøv igen. Vælge en bil mellem 1 og 6.");
                        break;
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
                    case 2:
                        car2();
                        break;
                    case 3:
                        car3();
                        break;
                    case 4:
                        car4();
                        break;
                    case 5:
                        car5();
                        break;
                    case 6:
                        car6();
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

            car1();
            car2();
            car3();
            car4();
            car5();
            car6();

            Console.WriteLine("\n\nTryk på en vilkårlig tast for at hente hovedmenuen");

            Console.ReadKey();
        }

        //Følgende 6 metoder indeholder oplysninger om hver respektive bil

        static void car1()
        {
            Console.WriteLine("------ Grundoplysninger om bil 1 ------\n");
            Console.WriteLine("Mærke: {0}", car1Make);
            Console.WriteLine("Model: {0}", car1Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car1Year, car1Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car1Econ);
            Console.WriteLine("Drivmidlet er {0}", car1FuelType);
        }

        static void car2()
        {
            Console.WriteLine("------ Grundoplysninger om bil 2 ------\n");
            Console.WriteLine("Mærke: {0}", car2Make);
            Console.WriteLine("Model: {0}", car2Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car2Year, car2Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car2Econ);
            Console.WriteLine("Drivmidlet er {0}", car2FuelType);
        }

        static void car3()
        {
            Console.WriteLine("------ Grundoplysninger om bil 3 ------\n");
            Console.WriteLine("Mærke: {0}", car3Make);
            Console.WriteLine("Model: {0}", car3Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car3Year, car3Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car3Econ);
            Console.WriteLine("Drivmidlet er {0}", car3Econ);
        }

        static void car4()
        {
            Console.WriteLine("------ Grundoplysninger om bil 4 ------\n");
            Console.WriteLine("Mærke: {0}", car4Make);
            Console.WriteLine("Model: {0}", car4Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car4Year, car4Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car4Econ);
            Console.WriteLine("Drivmidlet er {0}", car4Econ);
        }

        static void car5()
        {
            Console.WriteLine("------ Grundoplysninger om bil 5 ------\n");
            Console.WriteLine("Mærke: {0}", car5Make);
            Console.WriteLine("Model: {0}", car5Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car5Year, car5Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car5Econ);
            Console.WriteLine("Drivmidlet er {0}", car5Econ);
        }

        static void car6()
        {
            Console.WriteLine("------ Grundoplysninger om bil 6 ------\n");
            Console.WriteLine("Mærke: {0}", car6Make);
            Console.WriteLine("Model: {0}", car6Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.\n", car6Year, car6Mileage);
            Console.WriteLine("\n\n------ Økonomioplysninger om køretøjet: ------");
            Console.WriteLine("Forbrug (Km/l): {0}", car6Econ);
            Console.WriteLine("Drivmidlet er {0}", car6Econ);
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

