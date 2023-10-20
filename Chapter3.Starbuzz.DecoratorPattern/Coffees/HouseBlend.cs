namespace Chapter3.Starbuzz.DecoratorPattern.Coffees;

public class HouseBlend: Beverage
{
    #region Construction

    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return .89;
    }

    #endregion
}
