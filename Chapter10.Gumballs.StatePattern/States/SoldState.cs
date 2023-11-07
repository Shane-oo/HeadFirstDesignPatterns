namespace Chapter10.Gumballs.StatePattern.States;

public class SoldState: IState
{
    #region Fields

    private readonly GumballMachine _gumballMachine;

    #endregion

    #region Construction

    public SoldState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    #endregion

    #region Public Methods

    public void Dispense()
    {
        _gumballMachine.ReleaseBall();
        _gumballMachine.State = _gumballMachine.Count == 0 ? _gumballMachine.SoldOutState : _gumballMachine.NoQuarterState;
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry you already turned the crank");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, were already giving you a gumball");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball");
    }

    #endregion
}
