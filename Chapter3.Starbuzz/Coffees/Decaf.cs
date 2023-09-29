namespace Chapter3.Starbuzz.Coffees;

public class Decaf: Beverage
{
    #region Construction

    public Decaf()
    {
        Description = "Decaf Coffee";
    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return 1.05;
    }

    #endregion
}
