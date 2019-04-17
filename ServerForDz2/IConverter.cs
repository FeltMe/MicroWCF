using System.ServiceModel;

namespace ServerForDz2
{
    [ServiceContract]
    public interface IConverter
    {
        [OperationContract]
        ConvertedUnits LinearMeasure(double meters);
        [OperationContract]
        ConvertedUnits CelsiusToFahrenheit(double c);
        [OperationContract]
        ConvertedUnits FahrenheitToCelsius(double f);

    }
}
