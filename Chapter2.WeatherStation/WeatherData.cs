namespace Chapter2.WeatherStation;

public class WeatherData: ISubject
{
    #region Fields

    private readonly List<IObserver> _observers = new();

    #endregion

    #region Properties

    public float Humidity { get; set; }

    public float Pressure { get; set; }

    public float Temperature { get; set; }

    #endregion

    #region Private Methods

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    #endregion

    #region Public Methods

    public void NotifyObservers()
    {
        foreach(var observer in _observers)
        {
            observer.Update();
        }
    }

    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    #endregion
}
