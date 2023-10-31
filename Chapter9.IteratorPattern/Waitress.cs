using Chapter9.IteratorPattern.Menus;

namespace Chapter9.IteratorPattern;

public class Waitress
{
    #region Fields

    private readonly MenuComponent _allMenus;

    #endregion

    #region Construction

    public Waitress(MenuComponent allMenus)
    {
        _allMenus = allMenus;
    }

    #endregion

    #region Public Methods

    public void PrintMenu()
    {
        _allMenus.Print();
    }

    #endregion
}
