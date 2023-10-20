namespace Chapter6.HomeAutomation.CommandPattern.Lights;

public class LightOffCommand: ICommand
{
    #region Fields

    private readonly Light _light;

    #endregion

    #region Construction

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        _light.Off();
    }

    public void Undo()
    {
        _light.On();
    }

    #endregion
}
