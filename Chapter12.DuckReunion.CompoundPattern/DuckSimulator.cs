using Chapter12.DuckReunion.CompoundPattern.Ducks;
using Chapter12.DuckReunion.CompoundPattern.Geese;
using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern;

public class DuckSimulator
{
    public void Simulate(AbstractDuckFactory duckFactory)
    {
        var redheadDuck = duckFactory.CreateRedHeadDuck();
        var duckCall = duckFactory.CreateDuckCall();
        var rubberDuck = duckFactory.CreateRubberDuck();

        var gooseDuck = new GooseAdapter(new Goose());

        Console.WriteLine("\n Duck Simulator With Composite - Flocks");

        var flockOfDucks = new Flock();
        
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        var flockOfMallards = new Flock();
        
        var mallard1 = duckFactory.CreateMallardDuck();
        var mallard2 = duckFactory.CreateMallardDuck();
        var mallard3 = duckFactory.CreateMallardDuck();
        var mallard4 = duckFactory.CreateMallardDuck();
        
        flockOfMallards.Add(mallard1);
        flockOfMallards.Add(mallard2);
        flockOfMallards.Add(mallard3);
        flockOfMallards.Add(mallard4);
        
        flockOfDucks.Add(flockOfMallards);



        var quackoLogist = new Quackologist();
        flockOfDucks.RegisterObserver(quackoLogist);


        Console.WriteLine("\n Duck Simulator: Whole Flock Simulation");
        
        Simulate(flockOfDucks);
        
        Console.WriteLine("\n Duck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallards);

        Console.WriteLine("The ducks quacked " + QuackCounter.NumberOfQuacks + " times");
    }

    private void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}
