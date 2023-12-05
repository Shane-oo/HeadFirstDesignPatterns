using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern.Ducks;

public class Flock: IQuackable
{
    #region Fields

    private readonly Observable _observable;


    private readonly List<IQuackable> _quackers = new();

    #endregion

    #region Construction

    public Flock()
    {
        _observable = new Observable(this);
    }

    #endregion

    #region Public Methods

    public void Add(IQuackable quacker)
    {
        _quackers.Add(quacker);
    }

    public void NotifyObservers()
    {
    }

    public void Quack()
    {
        using var enumerator = _quackers.GetEnumerator();
        do
        {
            enumerator.Current?.Quack();
        } while(enumerator.MoveNext());

    }


    public void RegisterObserver(IObserver observer)
    { using var enumerator = _quackers.GetEnumerator();
        do
        {
            enumerator.Current?.RegisterObserver(observer);
        } while(enumerator.MoveNext());
       
    }

    #endregion
}
