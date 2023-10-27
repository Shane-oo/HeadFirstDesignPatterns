using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern.Menus;

public interface IMenu
{
    public IIterator<MenuItem> CreateIterator();
}
