namespace Chapter2.WeatherStation.ObserverPattern.Displays;

public class ForecastDisplay: IObserver, IDisplayElement
{
    #region Fields

    private readonly WeatherData _weatherData;

    #endregion

    #region Properties

    private float CurrentPressure { get; set; }

    private float LastPressure { get; set; }

    #endregion

    #region Construction

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    #endregion

    #region Public Methods

    public void Display()
    {
        Console.WriteLine($"Last Pressure {LastPressure} Current Pressure {CurrentPressure}");
    }

    public void Update()
    {
        LastPressure = CurrentPressure;
        CurrentPressure = _weatherData.Pressure;
        Display();
    }

    #endregion
}
