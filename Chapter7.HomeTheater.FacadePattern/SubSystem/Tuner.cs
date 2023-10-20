namespace Chapter7.HomeTheater.FacadePattern.SubSystem;

public class Tuner
{
    public int Frequency { get; set; }

    public Amplifier Amplifier { get; set; }


    public void On()
    {
        Console.WriteLine("Tuner On");
    }

    public void Off()
    {
        Console.WriteLine("Tuner Off");
    }

    public void SetAm()
    {
        Console.WriteLine("Tuner set to Am");
    }

    public void SetFm()
    {
        Console.WriteLine("Tuner set to Fm");
    }
}
