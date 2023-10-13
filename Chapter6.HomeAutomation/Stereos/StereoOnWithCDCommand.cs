namespace Chapter6.HomeAutomation.Stereos;

public class StereoOnWithCDCommand: ICommand
{
    #region Fields

    private readonly Stereo _stereo;

    #endregion

    #region Construction

    public StereoOnWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(11);
    }

    public void Undo()
    {
        _stereo.Off();
    }

    #endregion
}
