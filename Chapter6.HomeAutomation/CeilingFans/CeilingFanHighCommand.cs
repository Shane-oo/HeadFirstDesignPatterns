namespace Chapter6.HomeAutomation.CeilingFans;

public class CeilingFanHighCommand: ICommand
{
    private readonly CeilingFan _ceilingFan;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _ceilingFan.High();
        _ceilingFan.GetSpeed();
    }
}
