using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern.Geese;

public class GooseAdapter: IQuackable
{
    #region Fields

    private readonly Goose _goose;

    private readonly Observable _observable;

    #endregion

    #region Construction

    public GooseAdapter(Goose goose)
    {
        _goose = goose;
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
        _goose.Honk();
        NotifyObservers();
    }


    public void RegisterObserver(IObserver observer)
    {
        _observable.RegisterObserver(observer);
    }

    #endregion
}
