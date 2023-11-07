namespace Chapter10.Gumballs.StatePattern.States;

public class SoldOutState: IState
{private readonly GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }
    public void Dispense()
    {
        Console.WriteLine("No Gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You cant insert a Quarter, the machine is sold out");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned but there are no gumballs");
    }
}
