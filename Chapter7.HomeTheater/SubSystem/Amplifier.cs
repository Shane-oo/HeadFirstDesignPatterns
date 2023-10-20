namespace Chapter7.HomeTheater.SubSystem;

public class Amplifier
{
    public Tuner Tuner { get; set; }

    public Player Player { get; set; }

    public int Volume { get; set; }


public void On()
    {
        Console.WriteLine("Amplifier On");
    }

    public void Off()
    {
        Console.WriteLine("Amplifier Off");
    }

    public void SetSurroundSound()
    {
        Console.WriteLine("Amplifier Set to Surround Sound");
    }
    
    
    
    
}
