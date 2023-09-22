using Chapter1.SimUDuck.Ducks.Behaviours.FlyBehaviour;
using Chapter1.SimUDuck.Ducks.Behaviours.QuackBehaviour;

namespace Chapter1.SimUDuck.Ducks;

public class MallardDuck: Duck
{
    public MallardDuck()
    {
        QuackBehaviour = new Quacks();
        FlyBehaviour = new FliesWithWings();
    }

    public static void Display()
    {
        Console.WriteLine("Im a real Mallard Duck");
    } 
    
}
