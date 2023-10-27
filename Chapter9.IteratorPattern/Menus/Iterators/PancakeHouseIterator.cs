using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern;

public class PancakeHouseIterator: IIterator<MenuItem>
{
    #region Fields

    private readonly List<MenuItem> _menuItems;
    private int position;

    #endregion

    #region Construction

    public PancakeHouseIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    #endregion

    #region Public Methods

    public bool HasNext()
    {
        // double check
        return _menuItems.Count != position;
    }

    public MenuItem Next()
    {
        var menuItem = _menuItems[position];
        position++;
        return menuItem;
    }

    #endregion
}
