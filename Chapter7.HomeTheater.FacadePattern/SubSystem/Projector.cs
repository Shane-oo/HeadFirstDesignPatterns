namespace Chapter7.HomeTheater.FacadePattern.SubSystem;

public class Projector
{
    public Player Player { get; set; }


    public void On()
    {
        Console.WriteLine("Projector On");
    }

    public void Off()
    {
        Console.WriteLine("Projector Off");
    }

    public void TvMode()
    {
        Console.WriteLine("TV Mode");
    }

    public void WideScreenMode()
    {
        Console.WriteLine("Wide Screen Mode");
    }
}
