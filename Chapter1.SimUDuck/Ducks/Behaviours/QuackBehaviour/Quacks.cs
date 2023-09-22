namespace Chapter1.SimUDuck.Ducks.Behaviours.QuackBehaviour;

public class Quacks: IQuackBehaviour
{
    #region Public Methods

    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    #endregion
}
