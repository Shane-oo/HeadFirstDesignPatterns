namespace Chapter6.HomeAutomation.CommandPattern.CeilingFans;

public class CeilingFanOnHighCommand: ICommand
{
    private readonly CeilingFan _ceilingFan;

    public CeilingFanOnHighCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _ceilingFan.High();
        _ceilingFan.GetSpeed();
    }

    public void Undo()
    {
        _ceilingFan.Off();
    }
}
