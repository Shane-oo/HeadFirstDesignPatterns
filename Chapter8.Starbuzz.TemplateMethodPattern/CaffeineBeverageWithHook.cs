namespace Chapter8.Starbuzz.TemplateMethodPattern;

public abstract class CaffeineBeverageWithHook
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }

        Console.WriteLine("Beverage Prepared");
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

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
    
    // These are "hooks." Subclasses may override them, but it's not
    // mandatory since the hooks already have default (but empty)
    // implementation. Hooks provide additional extension points in some
    // crucial places of the algorithm.
    protected virtual void Hook1()
    {
    }
}
