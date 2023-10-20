namespace Chapter7.TurkeyAdapter.AdapterPattern;

public class WildTurkey: ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("Im flying a short distance");
    }
}
