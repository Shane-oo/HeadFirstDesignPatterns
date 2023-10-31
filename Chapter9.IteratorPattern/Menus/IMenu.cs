using Chapter9.IteratorPattern.Menus.Iterators;

namespace Chapter9.IteratorPattern.Menus;
// Unused
public interface IMenu
{
    public IEnumerator<MenuItem> CreateIterator();
}
