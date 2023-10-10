namespace Chapter6.HomeAutomation;

public class SimpleRemoteControl
{
    #region Fields

    private ICommand? _slot;

    #endregion

    #region Public Methods

    public void ButtonWasPressed()
    {
        _slot?.Execute();
    }

    public void SetCommand(ICommand? command)
    {
        _slot = command;
    }

    #endregion
}
