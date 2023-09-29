using Chapter4.PizzaStores.Ingredients;

namespace Chapter4.PizzaStores;

public abstract class Pizza
{
    #region Properties

    public string Name { get; set; }

    protected Cheese Cheese { get; set; }

    protected Clams Clam { get; set; }

    protected Dough Dough { get; set; }

    protected Sauce Sauce { get; set; }
    
    protected Pepperoni Pepperoni { get; set; }

    protected List<Veggie> Veggies { get; set; }

    #endregion

    #region Public Methods

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore Box");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public abstract void Prepare();

    public override string ToString()
    {
        return string.Empty; // code to print pizza here
    }

    #endregion
}
