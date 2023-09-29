namespace Chapter3.Starbuzz.Condiments;

public class SteamedMilk:CondimentDecorator
{

    public SteamedMilk(Beverage beverage)
    {
        _beverage = beverage;
        Description = _beverage.Description + ", Steamed Mild";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .10;
    }
}
