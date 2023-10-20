namespace Chapter2.WeatherStation.ObserverPattern.Displays;

public class CurrentConditionsDisplay: IObserver, IDisplayElement
{
    #region Fields

    private WeatherData _weatherData;

    #endregion

    #region Properties

    private float Humidity { get; set; }

    private float Pressure { get; set; }

    private float Temperature { get; set; }

    #endregion

    #region Construction

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    #endregion

    #region Public Methods

    public void Display()
    {
        Console.WriteLine($"Current Conditions {Temperature} F Degrees, {Humidity} % Humidity and {Pressure} Pressure");
    }

    public void Update()
    {
        Temperature = _weatherData.Temperature;
        Humidity = _weatherData.Humidity;
        Pressure = _weatherData.Pressure;
        Display();
    }

    #endregion
}
