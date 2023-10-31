namespace Chapter9.IteratorPattern.Menus;

public class MenuItem: MenuComponent
{
    #region Properties

    public sealed override string Description { get; set; }

    public sealed override string Name { get; set; }

    public sealed override double Price { get; set; }

    public sealed override bool Vegetarian { get; set; }

    #endregion

    #region Construction

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    #endregion

    #region Public Methods

    public override void Print()
    {
        Console.Write("  " + Name);
        if (Vegetarian)
        {
            Console.Write("(V)");
        }

        Console.WriteLine(", " + Price);
        Console.WriteLine("    -- " + Description);
    }

    #endregion
}
