namespace Chapter6.HomeAutomation.CommandPattern.Macros;

public class MacroCommand: ICommand
{
    #region Fields

    private readonly ICommand[] _commands;

    #endregion

    #region Construction

    public MacroCommand(ICommand[] commands)
    {
        _commands = commands;
    }

    #endregion

    #region Public Methods

    public void Execute()
    {
        foreach(var c in _commands)
        {
            c.Execute();
        }
    }

    public void Undo()
    {
        foreach(var c in _commands.Reverse())
        {
            c.Undo();
        }
    }

    #endregion
}
