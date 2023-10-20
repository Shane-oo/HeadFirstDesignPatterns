namespace Chapter2.WeatherStation.ObserverPattern;

public interface ISubject
{
    public void NotifyObservers();

    public void RegisterObserver(IObserver o);

    public void RemoveObserver(IObserver o);
}
