namespace Chapter3.Starbuzz.DecoratorPattern.Coffees;

public class Espresso: Beverage
{
    #region Construction

    public Espresso()
    {
        Description = $"Espresso Coffee";

    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return 1.99;
    }

    #endregion
}
