namespace Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

public class QuackCounter: IQuackable
{
    #region Fields

    private readonly IQuackable _duck;

    private readonly Observable _observable;

    #endregion

    #region Properties

    public static int NumberOfQuacks { get; set; }

    #endregion

    #region Construction

    public QuackCounter()
    {
        _observable = new Observable(this);
    }


    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    #endregion

    #region Public Methods

    public void NotifyObservers()
    {
        _duck.NotifyObservers();
    }

    public void Quack()
    {
        _duck.Quack();

        NumberOfQuacks++;
    }

    public void RegisterObserver(IObserver observer)
    {
        _duck.RegisterObserver(observer);
    }

    #endregion
}
