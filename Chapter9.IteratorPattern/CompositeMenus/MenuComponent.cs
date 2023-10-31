namespace Chapter9.IteratorPattern.Menus;

public abstract class MenuComponent
{
    #region Properties

    public virtual string Description { get; set; } = string.Empty;

    public virtual string Name { get; set; } = string.Empty;

    public virtual double Price { get; set; } = 0.0;

    public virtual bool Vegetarian { get; set; } = false;

    #endregion

    #region Public Methods

    public virtual void Add(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public virtual MenuComponent GetChild(int i)
    {
        throw new NotSupportedException();
    }

    public virtual void Print()
    {
        throw new NotSupportedException();
    }

    public virtual void Remove(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    #endregion
}
