namespace Chapter9.IteratorPattern.Menus;

public class CafeMenu: IMenu
{
    #region Fields

    private readonly Dictionary<string, MenuItem> _menuItems = new();


    public CafeMenu()
    {
        AddItem("Coffee", "Large Coffee", true, 3.59);
    }

    #endregion

    #region Private Methods

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        _menuItems.Add(name, menuItem);
    }

    #endregion

    #region Public Methods

    public IEnumerator<MenuItem> CreateIterator()
    {
        return _menuItems.Values.GetEnumerator();
    }

    #endregion
}
