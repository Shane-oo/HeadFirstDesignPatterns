using Chapter1.SimUDuck.Ducks.Behaviours.FlyBehaviour;
using Chapter1.SimUDuck.Ducks.Behaviours.QuackBehaviour;

namespace Chapter1.SimUDuck.Ducks;

public class ModelDuck: Duck
{
    public ModelDuck()
    {
        FlyBehaviour = new CantFly();
        QuackBehaviour = new Quacks();
    }

    public static void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}
