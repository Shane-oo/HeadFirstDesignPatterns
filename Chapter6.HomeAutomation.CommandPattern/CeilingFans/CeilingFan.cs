namespace Chapter6.HomeAutomation.CommandPattern.CeilingFans;

public class CeilingFan
{
    #region Fields

    private readonly string _room;
    private string _speed;

    public CeilingFan(string room)
    {
        _room = room;
    }

    #endregion

    #region Public Methods

    public string GetSpeed()
    {
        return _speed;
    }

    public void High()
    {
        _speed = "High";
        Console.WriteLine($" {_room} CeilingFan set to high");
    }

    public void Low()
    {
        _speed = "Low";
        Console.WriteLine($" {_room} CeilingFan set to low");
    }

    public void Medium()
    {
        _speed = "Medium";
        Console.WriteLine($" {_room} CeilingFan set to medium");
    }

    public void Off()
    {
        Console.WriteLine($" {_room} CeilingFan off");
    }

    #endregion
}
