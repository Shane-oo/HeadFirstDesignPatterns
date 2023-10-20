namespace Chapter8.Starbuzz.TemplateMethodPattern;

public class CoffeeWithHook: CaffeineBeverageWithHook
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping Coffee Through Filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    protected override bool CustomerWantsCondiments()
    {
        return GetUserInput();
    }

    private bool GetUserInput()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");

        var key = Console.ReadKey();
        var answer = key.KeyChar;
        return answer == 'y';
    }
}
