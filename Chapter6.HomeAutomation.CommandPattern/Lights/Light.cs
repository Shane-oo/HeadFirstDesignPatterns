namespace Chapter6.HomeAutomation.CommandPattern.Lights;

public class Light
{
    private readonly string _room;

    public Light(string room)
    {
        _room = room;
    }

    public void On()
    {
        Console.WriteLine($" {_room} Light Turned On");
    }

    public  void Off()
    {
        Console.WriteLine($" {_room} Light Turned Off");
    }
}
