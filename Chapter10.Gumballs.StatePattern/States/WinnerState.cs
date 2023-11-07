namespace Chapter10.Gumballs.StatePattern.States;

public class WinnerState: IState
{
    #region Fields

    private readonly GumballMachine _gumballMachine;

    #endregion

    #region Construction

    public WinnerState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    #endregion

    #region Public Methods

    public void Dispense()
    {
        throw new NotImplementedException();
    }

    public void EjectQuarter()
    {
        throw new NotImplementedException();
    }

    public void InsertQuarter()
    {
        throw new NotImplementedException();
    }

    public void TurnCrank()
    {
        throw new NotImplementedException();
    }

    #endregion
}
