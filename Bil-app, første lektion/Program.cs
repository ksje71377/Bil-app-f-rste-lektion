using CarApp;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
//Car App. Seneste opdatering 21-02. Tilføjet menu, drive modul og loops. 

namespace Bil_app__første_lektion
{
    //Static variabler - så de kan bruges tværs over metoderne:

    internal class Program
    {
       
        //Velkomst til programmet og menupunkt initialiseres

        static void Main(string[] args)
        {
            // Toyota Corolla
            Car toyotaCorollaCar = new Car("Toyota", "Corolla", 2015, 'd', 20);

            // Toyota Yaris
            Car toyotaYarisCar = new Car("Toyota", "Yaris", 2018, 'p', 25);

            Car[] cars = [toyotaCorollaCar, toyotaYarisCar];

            foreach (Car car in cars)
            {
                car.PrintCarDetails();
            }
            Console.ReadKey();
        }
    }
}

