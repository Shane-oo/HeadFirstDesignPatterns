using Chapter9.IteratorPattern.Menus;
using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern;

public class Waitress
{
    #region Fields

    private readonly IMenu _dinerMenu;
    private readonly IMenu _pancakeHouseMenu;

    #endregion

    #region Construction

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
    }

    #endregion

    #region Private Methods

    private static void PrintMenu(IIterator<MenuItem> iterator)
    {
        while(iterator.HasNext())
        {
            var menuItem = iterator.Next();
            Console.Write(menuItem.Name + ",");
            Console.Write(menuItem.Price + ",");
            Console.Write(menuItem.Description + ",");
        }
    }

    #endregion

    #region Public Methods

    public void PrintMenu()
    {
        var pancakeIterator = _pancakeHouseMenu.CreateIterator();
        var dinerIterator = _dinerMenu.CreateIterator();

        Console.WriteLine("MENU \n ---- \n BREAKFAST");
        PrintMenu(pancakeIterator);
        Console.WriteLine("\n LUNCH");
        PrintMenu(dinerIterator);
    }

    #endregion
}
