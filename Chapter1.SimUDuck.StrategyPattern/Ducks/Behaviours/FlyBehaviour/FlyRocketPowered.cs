namespace Chapter1.SimUDuck.StrategyPattern.Ducks.Behaviours.FlyBehaviour;

public class FlyRocketPowered: IFlyBehaviour
{
    #region Public Methods

    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }

    #endregion
}
