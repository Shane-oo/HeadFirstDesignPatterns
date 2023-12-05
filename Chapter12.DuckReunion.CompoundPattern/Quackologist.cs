using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern;

public class Quackologist: IObserver
{
    #region Public Methods

    public void Update(IQuackObservable duck)
    {
        Console.WriteLine("Quackologist: " + duck + " juat quacked");
    }

    #endregion
}
