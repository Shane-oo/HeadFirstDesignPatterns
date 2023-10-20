namespace Chapter6.HomeAutomation.CommandPattern.Stereos;

public class Stereo
{

    private readonly string _room;

    public Stereo(string room)
    {
        _room = room;
    }

    #region Public Methods

    public void On()
    {
        Console.WriteLine($" {_room} Stereo Turned On");
    }

    public void SetCD()
    {
        Console.WriteLine($" {_room} Set to Play CD");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($" {_room} Stereo set to volume {volume}");
    }

    public void Off()
    {
        Console.WriteLine($" {_room} Stereo Off");
    }
    

    #endregion
}
