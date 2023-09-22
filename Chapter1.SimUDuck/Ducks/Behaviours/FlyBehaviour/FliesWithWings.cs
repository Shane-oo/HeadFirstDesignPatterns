namespace Chapter1.SimUDuck.Ducks.Behaviours.FlyBehaviour;

public class FliesWithWings: IFlyBehaviour
{
    #region Public Methods

    public void Fly()
    {
        Console.WriteLine("I'm flying!");
    }

    #endregion
}