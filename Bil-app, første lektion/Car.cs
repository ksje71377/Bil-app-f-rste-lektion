using System.Globalization;

namespace CarApp;

public class Car
{
    private string brand;
    private string model;
    private int year;
    private char fuelType;
    private bool isEngineOn;
    private int odometer;
    private double kilometersPerLiter;
    public Car(string brandInput, string modelInput, int yearInput, char fuelTypeInput, double kilometersPerLiterInput)
    {
        brand = !String.IsNullOrEmpty(brandInput) ? brandInput : "Unknown";
        model = !String.IsNullOrEmpty(modelInput) ? modelInput : "Unknown";
        year = yearInput > 1886 ? yearInput : DateTime.Now.Year;
        fuelType = fuelTypeInput;
        kilometersPerLiter = kilometersPerLiterInput > 0 ? kilometersPerLiterInput : 0;
    }

    public void Drive(int tripDistanceInput)
    {
        // Tjek om distance er mindre end 0
        if (tripDistanceInput < 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        
        isEngineOn = true;
        
        odometer += tripDistanceInput;
        
        isEngineOn = false;
    }

    public double CalculateTripPrice(double fuelPriceInput, int tripDistanceInput)
    {
        // Tjek om brændstofpris eller distance er mindre end 0
        if (fuelPriceInput <= 0 || tripDistanceInput <= 0)
        {
            Console.WriteLine("Invalid input");
            return 0;
        }
        
        return fuelPriceInput * (tripDistanceInput / kilometersPerLiter);
    }

    public string[] GetCarDetails()
    {
        // Return car details
        return [
            brand,
            model,
            Convert.ToString(year),
            GetFuelType(),
            Convert.ToString(isEngineOn),
            Convert.ToString(odometer),
            Convert.ToString(kilometersPerLiter, CultureInfo.CurrentCulture),
        ];
    }
    
    public string GetBrand()
    {
        return brand;
    }
    
    public void SetBrand(string brandInput)
    {
        brand = !String.IsNullOrEmpty(brandInput) ? brandInput : "Unknown";
    }
    
    public string GetModel()
    {
        return model;
    }
    
    public void SetModel(string modelInput)
    {
        model = !String.IsNullOrEmpty(modelInput) ? modelInput : "Unknown";
    }
    
    public int GetYear()
    {
        return year;
    }
    
    public void SetYear(int yearInput)
    {
        year = yearInput > 1886 ? yearInput : DateTime.Now.Year;
    }
    
    public string GetFuelType()
    {
        switch (char.ToUpper(fuelType)) {
            case 'D':
                return "Diesel";
            case 'P':
                return "Petrol";
            default:
                return "Unknown";
        }
    }
    
    public void SetFuelType(char fuelTypeInput)
    {
        fuelType = fuelTypeInput;
    }
    
    public bool GetIsEngineOn()
    {
        return isEngineOn;
    }
    
    
}