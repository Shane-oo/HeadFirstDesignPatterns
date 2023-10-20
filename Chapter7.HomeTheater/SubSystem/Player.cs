namespace Chapter7.HomeTheater.SubSystem;

public class Player
{
    
    public void On(){
        Console.WriteLine("Player On");
    }

    public void Off()
    {
        Console.WriteLine("Player Off");
    }

    public void Pause()
    {
        Console.WriteLine("Player Paused");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"Playing {movie}");
    }

    public void SetSurroundAudio()
    {
        Console.WriteLine("Set Surround Audio");
    }

    public void SetTwoChannelAudio()
    {
        Console.WriteLine("Set Two Channel Audio");
    }

    public void Stop()
    {
        Console.WriteLine("Player Stopped");
    }
    
    
    
}
