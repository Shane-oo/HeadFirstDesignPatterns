using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern.Menus;

public class PancakeHouseMenu :IMenu
{
    #region Fields

    private readonly List<MenuItem> _menuItems;

    #endregion

    #region Construction

    public PancakeHouseMenu()
    {
        _menuItems = new List<MenuItem>();

        AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
        AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausages", true, 2.99);
        AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
        AddItem("Waffles", "Waggles with your choice of blueberries or strawberries", true, 3.59);
    }

    #endregion

    #region Private Methods

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        _menuItems.Add(menuItem);
    }

    #endregion

    #region Public Methods

    public IIterator<MenuItem> CreateIterator()
    {
        return new PancakeHouseIterator(_menuItems);
    }

    #endregion
}
