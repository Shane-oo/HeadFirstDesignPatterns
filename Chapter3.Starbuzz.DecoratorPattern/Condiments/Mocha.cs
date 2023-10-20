namespace Chapter3.Starbuzz.DecoratorPattern.Condiments;

public class Mocha: CondimentDecorator
{
    #region Construction

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
        Description = _beverage.Description + ", Mocha";
    }

    #endregion

    #region Public Methods

    public override double Cost()
    {
        return _beverage.Cost() + .20;
    }

    #endregion
}
