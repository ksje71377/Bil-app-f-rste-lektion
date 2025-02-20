using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
//Car App. Seneste opdatering 20-02. Tilføjet menu, drive modul og loops. 

namespace Bil_app__første_lektion
{
    //Static variabler - så de kan bruges tværs over metoderne:

    internal class Program
    {
        static int mainMenuQuery = 1;
        static int readCarDetailsChoice;
        static int continueQuery;
        static int continueQuery2;

        static string car1Make;
        static string car1Model;
        static int car1Year;
        static int car1Mileage;

        static string car2Make;
        static string car2Model;
        static int car2Year;
        static int car2Mileage;

        static string car3Make;
        static string car3Model;
        static int car3Year;
        static int car3Mileage;

        static string car4Make;
        static string car4Model;
        static int car4Year;
        static int car4Mileage;

        static string car5Make;
        static string car5Model;
        static int car5Year;
        static int car5Mileage;

        static string car6Make;
        static string car6Model;
        static int car6Year;
        static int car6Mileage;

        //readCarDetails metode. Bruger indtaster ønskede bil og switch gemmer herefter i den korrekte variabel. 

        static void readCarDetails()
        {
            //Løkke initialiseres - brugeren angiver efter indtastning af 1 bil, om flere skal indtastes. 

            do

            {

                //Bruger vælger mellem bil nr. 1 til 6 gennem undermenuen:

                Console.WriteLine("Vælg mellem bil nr. 1 til og med 6. ved at indtaste tallet for den ønskede bil forneden:");

                int.TryParse(Console.ReadLine(), out readCarDetailsChoice);

                // Bruger indtaster for bil nr 1 og gemmer det i variablen

                switch (readCarDetailsChoice)
                {
                    case 1:
                        Console.WriteLine("Du indtaster nu data for bil nr. 1");

                        Console.WriteLine("Indtast fabrikanten");

                        car1Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car1Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car1Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car1Mileage);

                        break;

                    // Bruger indtaster for bil nr 2 og gemmer det i variablen

                    case 2:
                        Console.WriteLine("Du indtaster nu data for bil nr. 2");

                        Console.WriteLine("Indtast fabrikanten");

                        car2Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car2Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car2Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car2Mileage);

                        break;

                    // Bruger indtaster for bil nr 2 og gemmer det i variablen

                    case 3:
                        Console.WriteLine("Du indtaster nu data for bil nr. 3");

                        Console.WriteLine("Indtast fabrikanten");

                        car3Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car3Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car3Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car3Mileage);

                        break;

                    // Bruger indtaster for bil nr 4 og gemmer det i variablen

                    case 4:
                        Console.WriteLine("Du indtaster nu data for bil nr. 4");

                        Console.WriteLine("Indtast fabrikanten");

                        car4Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car4Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car4Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car4Mileage);

                        break;

                    // Bruger indtaster for bil nr 5 og gemmer det i variablen

                    case 5:
                        Console.WriteLine("Du indtaster nu data for bil nr. 5");

                        Console.WriteLine("Indtast fabrikanten");

                        car5Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car5Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car5Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car5Mileage);

                        break;

                    // Bruger indtaster for bil nr 6 og gemmer det i variablen

                    case 6:
                        Console.WriteLine("Du indtaster nu data for bil nr. 6");

                        Console.WriteLine("Indtast fabrikanten");

                        car6Make = Console.ReadLine();

                        Console.WriteLine("Indtast modellen");

                        car6Model = Console.ReadLine();

                        Console.WriteLine("Indtast årgangen");

                        int.TryParse(Console.ReadLine(), out car6Year);

                        Console.WriteLine("Indtast bilens kilometerstand");

                        int.TryParse(Console.ReadLine(), out car6Mileage);

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
        static void readTripModule()
        {
            Console.WriteLine("Trip modulet");
        }
        static void readTripEconomy()
        {
            Console.WriteLine("Trip economy");
        }
        static void readPalindrome()
        {
            Console.WriteLine("palindrom check");
        }
        static void readCarSingularData()
        {
            do
            {
                Console.WriteLine("Oplysninger om det enkelte køretøj. Angiv et tal fra 1-6 på den bil som du ønsker at se oplysninger omkring forneden:");
            }

            while (continueQuery2 == 1);
            Console.WriteLine("Vil du fremsøge data på en af de andre biler nu? Tast 1. Tast hvilken som helst anden for at vende tilbage til hovedmenuen");
        }
        static void readCarTotalData()
        {
            Console.WriteLine("Total data for alle biler");
        }

        //Følgende 6 metoder indeholder oplysninger om hver respektive bil

        static void car1()
        {
            Console.WriteLine("Viser data for bil 1\n");
            Console.WriteLine("Mærke: {0}", car1Make);
            Console.WriteLine("Model: {0}", car1Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car1Year, car1Mileage);
        }
        static void car2()
        {
            Console.WriteLine("Viser data for bil 2\n");
            Console.WriteLine("Mærke: {0}", car2Make);
            Console.WriteLine("Model: {0}", car2Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car2Year, car2Mileage);
        }
        static void car3()
        {
            Console.WriteLine("Viser data for bil 3\n");
            Console.WriteLine("Mærke: {0}", car3Make);
            Console.WriteLine("Model: {0}", car3Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car3Year, car3Mileage);
        }
        static void car4()
        {
            Console.WriteLine("Viser data for bil 4\n");
            Console.WriteLine("Mærke: {0}", car4Make);
            Console.WriteLine("Model: {0}", car4Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car4Year, car4Mileage);
        }
        static void car5()
        {
            Console.WriteLine("Viser data for bil 5\n");
            Console.WriteLine("Mærke: {0}", car5Make);
            Console.WriteLine("Model: {0}", car5Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car5Year, car5Mileage);
        }
        static void car6()
        {
            Console.WriteLine("Viser data for bil 6\n");
            Console.WriteLine("Mærke: {0}", car6Make);
            Console.WriteLine("Model: {0}", car6Model);
            Console.WriteLine("\n\nPågældende bil er fra år {0} og har tilbagelagt {1} kilometer.", car6Year, car6Mileage);
        }
        static void Main(string[] args)
        {
            do
            {

                int menuChoice;
                //Velkomst til programmet og menupunkt initialiseres
                Console.WriteLine("Velkommen til CarApp version 1.01\n\nVælg den ønskede funktion i menuen for neden:\n\n");
                Console.WriteLine("Tast '1' for at indlæse biloplysninger.\n\nTast '2' for at starte \"Drive\" modulet.\n\nTast '3' for at beregne tur-økonomi.\n\nTast '4' for at åbne Palindrom-tjek\n\nTast '5' for at se detaljer om enkelt bil.\n\nTast '6' for at se detaljer om alle biler.");

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
