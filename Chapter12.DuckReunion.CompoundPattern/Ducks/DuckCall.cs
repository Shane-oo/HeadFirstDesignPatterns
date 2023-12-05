using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern.Ducks;

public class DuckCall: IQuackable
{
    #region Fields

    private readonly Observable _observable;

    #endregion

    #region Construction

    public DuckCall()
    {
        _observable = new Observable(this);
    }

    #endregion

    #region Public Methods

    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void Quack()
    {
        Console.WriteLine("Kwak");
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observable.RegisterObserver(observer);
    }

    #endregion
}
