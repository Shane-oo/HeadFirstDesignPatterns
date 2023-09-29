namespace Chapter3.Starbuzz.Condiments;

public class Soy: CondimentDecorator
{
    #region Construction

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
        Description = _beverage.Description + ", Soy";
    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return _beverage.Cost() + .15;
    }

    #endregion
}
