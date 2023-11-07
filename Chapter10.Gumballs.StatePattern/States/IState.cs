namespace Chapter10.Gumballs.StatePattern;

public interface IState
{
    public void Dispense();

    public void EjectQuarter();

    public void InsertQuarter();

    public void TurnCrank();
}
