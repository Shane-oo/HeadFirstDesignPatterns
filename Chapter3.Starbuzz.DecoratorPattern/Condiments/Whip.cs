namespace Chapter3.Starbuzz.DecoratorPattern.Condiments;

public class Whip: CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        _beverage = beverage;
        Description = _beverage.Description + ", Whip";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .10;
    }
}
