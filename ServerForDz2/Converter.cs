using System;

namespace ServerForDz2
{
    public class Converter : IConverter
    {
        const double MetrToInches = 39.3700787;
        const double MetrToYards = 1.0936133;
        const double MetrToFeets = 3.2808399;
        const double FahrenheitMultiplier = 1.8;
        const int FahrenheitConst = 32;

        public ConvertedUnits LinearMeasure(double meters)
        {
            ConvertedUnits Units = new ConvertedUnits
            {
                Feets = meters * MetrToFeets,
                Inches = meters * MetrToInches,
                Yards = meters * MetrToYards
            };
            Console.WriteLine("Metr Converter was called");
            return Units;
        }
        public ConvertedUnits CelsiusToFahrenheit(double c)
        {
            ConvertedUnits Units = new ConvertedUnits
            {
                Fahrenheit = (c * FahrenheitMultiplier) + FahrenheitConst
            };
            Console.WriteLine("Celsius Converter was called");
            return Units;
        }
        public ConvertedUnits FahrenheitToCelsius(double f)
        {
            ConvertedUnits Units = new ConvertedUnits
            {
                Fahrenheit = (f - FahrenheitConst) / FahrenheitMultiplier
            };
            Console.WriteLine("Fahrenheit Converter was called");
            return Units;
        }
    }
}
