namespace Chapter3.Starbuzz;

public abstract class Beverage
{
    public string Description { get; set; } =  "Unknown Beverage";

    public abstract double Cost();
}
