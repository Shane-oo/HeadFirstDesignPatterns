using System.Collections;

namespace Chapter9.IteratorPattern;

public class PancakeHouseIterator: IEnumerator<MenuItem>
{
    #region Fields

    private readonly List<MenuItem> _menuItems;
    private int _position = -1;

    #endregion

    #region Properties

    public MenuItem Current
    {
        get
        {
            try
            {
                return _menuItems[_position];
            }
            catch(IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current => Current;

    #endregion

    #region Construction

    public PancakeHouseIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    #endregion

    #region Public Methods

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        _position++;
        return _position < _menuItems.Count;
    }

    public void Reset()
    {
        _position = -1;
    }

    #endregion
}
