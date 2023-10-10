namespace Chapter6.HomeAutomation.CeilingFans;

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

    #endregion
}
