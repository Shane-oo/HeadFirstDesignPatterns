namespace Chapter1.SimUDuck.Ducks.Behaviours.QuackBehaviour;

public class SilentQuacks: IQuackBehaviour
{
    #region Public Methods

    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }

    #endregion
}