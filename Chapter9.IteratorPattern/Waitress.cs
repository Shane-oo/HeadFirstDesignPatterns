using Chapter9.IteratorPattern.Menus;
using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern;

public class Waitress
{
    #region Fields

    private readonly IMenu _dinerMenu;
    private readonly IMenu _pancakeHouseMenu;
    private readonly IMenu _cafeMenu;

    #endregion

    #region Construction

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
        _cafeMenu = cafeMenu;
    }

    #endregion

    #region Private Methods

    private static void PrintMenu(IEnumerator<MenuItem> iterator)
    {
        while(iterator.MoveNext())
        {
            var menuItem = iterator.Current;
            Console.Write(menuItem!.Name + ",");
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
        var cafeIterator = _cafeMenu.CreateIterator();
        
        Console.WriteLine("MENU \n ---- \n BREAKFAST");
        PrintMenu(pancakeIterator);
        Console.WriteLine("\n LUNCH");
        PrintMenu(dinerIterator);
        Console.WriteLine("\n CAFE");
        PrintMenu(cafeIterator);
    }

    #endregion
}
