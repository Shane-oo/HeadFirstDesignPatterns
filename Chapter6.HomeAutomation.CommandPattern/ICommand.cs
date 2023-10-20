namespace Chapter6.HomeAutomation.CommandPattern;

public interface ICommand
{
    public void Execute();

    public void Undo();
}
