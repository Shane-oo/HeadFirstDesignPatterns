using Chapter7.HomeTheater.SubSystem;

namespace Chapter7.HomeTheater;

public class HomeTheaterFacade
{
    #region Fields

    private readonly Amplifier _amplifier;
    private readonly Player _player;
    private readonly PopCornPopper _popCornPopper;
    private readonly Projector _projector;
    private readonly Screen _screen;
    private readonly TheaterLights _theaterLights;
    private readonly Tuner _tuner;

    #endregion

    #region Construction

    public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, Player player, Projector projector, TheaterLights theaterLights, Screen screen, PopCornPopper popCornPopper)
    {
        _amplifier = amplifier;
        _tuner = tuner;
        _player = player;
        _projector = projector;
        _theaterLights = theaterLights;
        _screen = screen;
        _popCornPopper = popCornPopper;
    }

    #endregion

    #region Public Methods

    public void EndMovie()
    {
    }

    public void EndRadio()
    {
    }

    public void ListenToRadio()
    {
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get Ready To Watch A Movie...");
        _popCornPopper.On();
        _popCornPopper.Pop();
        _theaterLights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amplifier.On();
        _amplifier.Player = _player;
        _amplifier.SetSurroundSound();
        _amplifier.Volume = 5;
        _player.On();
        _player.Play(movie);
    }

    #endregion
}
