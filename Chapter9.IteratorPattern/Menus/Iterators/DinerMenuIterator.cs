namespace Chapter9.IteratorPattern.Menus.Iterators;

public class DinerMenuIterator: IIterator<MenuItem>
{
    #region Fields

    private readonly MenuItem[] _menuItems;
    private int _position;

    #endregion

    #region Construction

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        _menuItems = menuItems;
    }

    #endregion

    #region Public Methods

    public bool HasNext()
    {
        return _position < _menuItems.Length && _menuItems[_position] != null;
    }

    public MenuItem Next()
    {
        var menuItem = _menuItems[_position];
        _position++;
        return menuItem;
    }

    #endregion
}
