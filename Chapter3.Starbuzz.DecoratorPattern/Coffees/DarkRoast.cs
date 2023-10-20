namespace Chapter3.Starbuzz.DecoratorPattern.Coffees;

public class DarkRoast: Beverage
{
    #region Construction

    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return 0.99;
    }

    #endregion
}
