namespace Chapter2.WeatherStation.ObserverPattern.Displays;

public class HeatIndexDisplay: IObserver, IDisplayElement
{
    #region Properties

    private float HeatIndex { get; set; }

    private readonly WeatherData _weatherData;

    #endregion

    #region Construction

    public HeatIndexDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    #endregion

    #region Public Methods

    public void Display()
    {
        Console.WriteLine($"Heat Index is {HeatIndex}");
    }

    public void Update()
    {
        var t = _weatherData.Temperature;
        var rh = _weatherData.Humidity;

        HeatIndex = (float)(16.923 + 0.185212 * t + 5.37941 * rh - 0.100254 * t * rh +
                            0.00941695 * (t * t) + 0.00728898 * (rh * rh) +
                            0.000345372 * (t * t * rh) - 0.000814971 * (t * rh * rh) +
                            0.0000102102 * (t * t * rh * rh) - 0.000038646 * (t * t * t) + 0.0000291583 *
                            (rh * rh * rh) + 0.00000142721 * (t * t * t * rh) +
                            0.000000197483 * (t * rh * rh * rh) - 0.0000000218429 * (t * t * t * rh * rh) +
                            0.000000000843296 * (t * t * rh * rh * rh) -
                            0.0000000000481975 * (t * t * t * rh * rh * rh));
        Display();
    }

    #endregion
}
