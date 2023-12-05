using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern.Ducks;

public class RedheadDuck: IQuackable
{
    #region Fields

    private readonly Observable _observable;

    #endregion

    #region Construction

    public RedheadDuck()
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
        Console.WriteLine("Quack!");
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observable.RegisterObserver(observer);
    }

    #endregion
}
