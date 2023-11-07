namespace Chapter10.Gumballs.StatePattern.States;

public class NoQuarterState: IState
{
    private readonly GumballMachine _gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _gumballMachine.State = _gumballMachine.HasQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned but theres no quarter");
    }
}
