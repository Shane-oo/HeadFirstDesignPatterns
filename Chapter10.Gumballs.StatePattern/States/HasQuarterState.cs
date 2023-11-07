namespace Chapter10.Gumballs.StatePattern.States;

public class HasQuarterState: IState
{
    private readonly GumballMachine _gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("You need to turn the crank");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        _gumballMachine.State = _gumballMachine.NoQuarterState;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You cant insert another quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        _gumballMachine.State = _gumballMachine.SoldState;
    }
}
