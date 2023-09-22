namespace Chapter1.SimUDuck.Ducks.Behaviours.FlyBehaviour;

public class CantFly: IFlyBehaviour
{
    #region Public Methods

    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }

    #endregion
}