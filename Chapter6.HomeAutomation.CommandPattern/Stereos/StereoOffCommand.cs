namespace Chapter6.HomeAutomation.CommandPattern.Stereos;

public class StereoOffCommand: ICommand
{
    #region Fields

    private readonly Stereo _stereo;

    #endregion

    #region Construction

    public StereoOffCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        _stereo.Off();
    }

    public void Undo()
    {
        _stereo.On();
    }

    #endregion
}
