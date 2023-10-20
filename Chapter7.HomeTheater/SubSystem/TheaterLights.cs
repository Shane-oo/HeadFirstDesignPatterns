namespace Chapter7.HomeTheater.SubSystem;

public class TheaterLights
{
    #region Properties

    public int Dimness { get; set; }

    #endregion

    #region Public Methods

    public void Dim(int dimness)
    {
        Dimness = dimness;
        Console.WriteLine($"Lights Dimmed To {Dimness}");
    }

    #endregion
}
