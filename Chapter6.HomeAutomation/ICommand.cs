namespace Chapter6.HomeAutomation;

public interface ICommand
{
    public void Execute();

    public void Undo();
}