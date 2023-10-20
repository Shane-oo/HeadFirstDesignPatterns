namespace Chapter8.Starbuzz.TemplateMethodPattern;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
          BoilWater();
          Brew();
          PourInCup();  
          AddCondiments();
    }
    // These operations have to be implemented in subclasses.
    protected abstract void Brew();

    protected abstract void AddCondiments();

    // These operations already have implementations.
    private void BoilWater()
    {
        Console.WriteLine("Boiling Water");
    }

    private void PourInCup()
    {
        Console.WriteLine("Pouring Into Cup");
    }
    
}
