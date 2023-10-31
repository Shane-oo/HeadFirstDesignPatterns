namespace Chapter9.IteratorPattern.Menus;

public class Menu: MenuComponent
{
    #region Fields

    private readonly List<MenuComponent> _menuComponents = new();

    #endregion

    #region Properties

    public sealed override string Description { get; set; }

    // we leave out price and vegetarian as it doesn't make sense for a menu
    public sealed override string Name { get; set; }

    #endregion

    #region Construction

    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
    }

    #endregion

    #region Public Methods

    public override void Add(MenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override MenuComponent GetChild(int i)
    {
        return _menuComponents[i];
    }

    public override void Print()
    {
        Console.Write("\n " + Name);
        Console.WriteLine(", " + Description);
        Console.WriteLine("------------------");

        foreach(var menuComponent in _menuComponents)
        {
            menuComponent.Print();
        }
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    #endregion
}
