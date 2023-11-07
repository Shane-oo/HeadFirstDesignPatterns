using Chapter10.Gumballs.StatePattern.States;

namespace Chapter10.Gumballs.StatePattern;

public class GumballMachine
{
    #region Properties

    public int Count { get; set; }

    public IState HasQuarterState { get; }

    public IState NoQuarterState { get; }

    public IState SoldOutState { get; }

    public IState SoldState { get; }

    public IState State { get; set; }

    public IState WinnerState { get; }

    #endregion

    #region Construction

    public GumballMachine(int count)
    {
        SoldOutState = new SoldState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        WinnerState = new WinnerState(this);

        Count = count;
        State = count > 0 ? NoQuarterState : SoldOutState;
    }

    #endregion

    #region Public Methods

    public void EjectQuarter()
    {
        State.EjectQuarter();
    }

    public void InsertQuarter()
    {
        State.InsertQuarter();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling oit the slot");
        if (Count > 0)
        {
            Count--;
        }
    }

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense();
    }

    #endregion
}
