using Chapter4.PizzaStores.Ingredients;
using Chapter4.PizzaStores.Ingredients.ChicagoIngredients;

namespace Chapter4.PizzaStores.IngredientFactories;

// Example of Abstract Factory
// Each Concrete SubClass creates a family of products
// For instance the subclass decides the type of dough...
public class ChicagoPizzaIngredientFactory: IPizzaIngredientFactory
{
    #region Public Methods

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Clams CreateClam()
    {
        return new FrozenClams();
    }

    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public List<Veggie> CreateVeggies()
    {
        return new List<Veggie>
               {
                   new BlackOlives(),
                   new EggPlant(),
                   new Spinach()
               };
    }

    #endregion
}
