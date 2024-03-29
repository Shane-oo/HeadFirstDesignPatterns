namespace Chapter6.HomeAutomation.CommandPattern.CeilingFans;

public class CeilingFanOffCommand: ICommand
{
    #region Fields

    private readonly CeilingFan _ceilingFan;

    #endregion

    #region Construction

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        _ceilingFan.Off();
    }

    public void Undo()
    {
        _ceilingFan.High();
        _ceilingFan.GetSpeed();
    }

    #endregion
}
