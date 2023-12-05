namespace Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

public interface IObserver
{
    public void Update(IQuackObservable duck);
}

public interface IQuackObservable
{
    public void NotifyObservers();

    public void RegisterObserver(IObserver observer);
}

public class Observable: IQuackObservable
{
    #region Fields

    private readonly IQuackObservable _duck;
    private readonly List<IObserver> _observers = new();

    #endregion

    #region Construction

    public Observable(IQuackObservable duck)
    {
        _duck = duck;
    }

    #endregion

    #region Public Methods

    public void NotifyObservers()
    {
        using var enumerator = _observers.GetEnumerator();
        do
        {
            enumerator.Current?.Update(_duck);
        } while(enumerator.MoveNext());
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    #endregion
}
