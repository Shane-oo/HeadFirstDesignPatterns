namespace Chapter6.HomeAutomation;

public class RemoteControl
{
    #region Constants

    private const int SLOTS = 7;

    #endregion

    #region Fields

    private readonly ICommand[] _offCommands = new ICommand[SLOTS];
    private readonly ICommand[] _onCommands = new ICommand[SLOTS]; // 7 Slots on remote

    #endregion

    #region Construction

    public RemoteControl()
    {
        var noCommand = new NoCommand();
        for(var i = 0; i < 7; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
    }

    #endregion

    #region Public Methods

    public void OffButtonWasPushed(int slot)
    {
        _offCommands[slot].Execute();
    }

    public void OnButtonWasPushed(int slot)
    {
        _onCommands[slot].Execute();
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public override string ToString()
    {
        var toString = "\n------ Remote Control ------\n";
        for(var i = 0; i < _onCommands.Length; i++)
        {
            toString += $"[slot {i}]" + _onCommands[i] + "     " + _offCommands[i] +"\n";
        }

        return toString;
    }

    #endregion
}
