using Chapter4.PizzaStores.Ingredients;
using Chapter4.PizzaStores.Ingredients.NYIngredients;

namespace Chapter4.PizzaStores.IngredientFactories;

// Example of Abstract Factory
// Each Concrete SubClass creates a family of products
// For instance the subclass decides the type of dough...
public class NYPizzaIngredientFactory: IPizzaIngredientFactory
{
    #region Public Methods

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clams CreateClam()
    {
        return new FreshClams();
    }

    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public List<Veggie> CreateVeggies()
    {
        return new List<Veggie>
               {
                   new Garlic(),
                   new Onion(),
                   new Mushroom(),
                   new RedPepper()
               };
    }

    #endregion
}
