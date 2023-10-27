namespace Chapter9.IteratorPattern;

public class MenuItem
{
    #region Properties

    public string Description { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public bool Vegetarian { get; set; }

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
}
