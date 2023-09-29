using Chapter4.PizzaStores.Ingredients;

namespace Chapter4.PizzaStores;

// Example of Abstract Factory
// Provides an abstract interface for creating a family of produces
public interface IPizzaIngredientFactory
{
    public Cheese CreateCheese();

    public Clams CreateClam();

    public Dough CreateDough();

    public Pepperoni CreatePepperoni();

    public Sauce CreateSauce();

    public List<Veggie> CreateVeggies();
}
