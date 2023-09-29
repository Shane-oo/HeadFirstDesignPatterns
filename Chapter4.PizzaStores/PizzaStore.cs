namespace Chapter4.PizzaStores;

// example of Factory Method
// provides an abstract interface for creating one product
public abstract class PizzaStore
{
    #region Private Methods

    // all the responsibility for instantiating Pizzas has been moved into a method that acts as a factory
    protected abstract Pizza CreatePizza(string type);

    #endregion

    #region Public Methods

    public Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    #endregion
}
