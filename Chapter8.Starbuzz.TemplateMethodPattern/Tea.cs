namespace Chapter8.Starbuzz.TemplateMethodPattern;

public class Tea: CaffeineBeverage
{
    #region Public Methods

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }

    protected override void Brew()
    {
        Console.WriteLine("Steeping The Tea");
    }

    

    #endregion
}
