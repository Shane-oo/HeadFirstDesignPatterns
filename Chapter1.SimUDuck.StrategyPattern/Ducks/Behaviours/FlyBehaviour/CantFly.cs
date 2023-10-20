namespace Chapter1.SimUDuck.StrategyPattern.Ducks.Behaviours.FlyBehaviour;

public class CantFly: IFlyBehaviour
{
    #region Public Methods

    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }

    #endregion
}