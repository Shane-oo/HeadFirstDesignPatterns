namespace Chapter6.HomeAutomation.CommandPattern.Lights;

public class LightOnCommand: ICommand
{
    #region Fields

    private readonly Light _light;

    #endregion

    #region Construction

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        _light.On();
    }

    public void Undo()
    {
        _light.Off();
    }

    #endregion
}
