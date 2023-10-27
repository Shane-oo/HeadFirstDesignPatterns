using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern.Menus;

public class DinerMenu: IMenu
{
    #region Constants

    private const int MAX_ITEMS = 6;

    #endregion

    #region Fields

    private readonly MenuItem[] _menuItems;

    private int _numberOfItems;

    #endregion

    #region Construction

    public DinerMenu()
    {
        _menuItems = new MenuItem[MAX_ITEMS];

        AddItem("Vegetarian BLT", "Fakin Bacon with lettuce & tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with side of potato salad", false, 3.29);
        AddItem("HotDog", "A HotDog", false, 3.05);
    }

    #endregion

    #region Private Methods

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        if (_numberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Menu is Full!");
        }
        else
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems++;
        }
    }

    #endregion

    #region Public Methods

    public IEnumerator<MenuItem> CreateIterator()
    {
        return new DinerMenuIterator(_menuItems);
    }

    #endregion
}
