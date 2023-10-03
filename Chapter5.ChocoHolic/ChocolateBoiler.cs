namespace Chapter5.ChocoHolic;

public class ChocolateBoiler
{
    #region Properties

    public bool Boiled { get; set; }

    public bool Empty { get; set; }

    private static ChocolateBoiler Instance { get; set; }

    #endregion

    #region Construction

    private ChocolateBoiler()
    {
        Empty = true;
        Boiled = false;
    }

    #endregion

    #region Public Methods

    // Returns Single Instance
    public static ChocolateBoiler GetInstance()
    {
        // If Instance is null Set Instance to new ChocolateBoiler
        return Instance ??= new ChocolateBoiler();
    }

    #endregion
}
