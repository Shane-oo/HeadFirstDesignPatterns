namespace Chapter1.SimUDuck.Ducks.Behaviours.QuackBehaviour;

public class Squeaks: IQuackBehaviour
{
    #region Public Methods

    public void Quack()
    {
        Console.WriteLine("Squeak");
    }

    #endregion
}
