namespace Chapter9.IteratorPattern.Menus.Iterators;

public interface IIterator<out T>
{
    public bool HasNext();

    public T Next();

}
