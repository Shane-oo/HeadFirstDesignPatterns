using Chapter1.SimUDuck.StrategyPattern.Ducks.Behaviours.FlyBehaviour;
using Chapter1.SimUDuck.StrategyPattern.Ducks.Behaviours.QuackBehaviour;

namespace Chapter1.SimUDuck.StrategyPattern.Ducks;

public class Duck
{
    #region Fields

    protected IFlyBehaviour FlyBehaviour { get; set; }

    protected IQuackBehaviour QuackBehaviour { get; set; }

    #endregion



    #region Public Methods

    public void PerformFly()
    {
        FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        QuackBehaviour.Quack();
    }

    public void SetFlyBehaviour(IFlyBehaviour fb)
    {
        FlyBehaviour = fb;
    }

    public void SetQuackBehaviour(IQuackBehaviour qb)
    {
        QuackBehaviour = qb;
    }

    #endregion
}
