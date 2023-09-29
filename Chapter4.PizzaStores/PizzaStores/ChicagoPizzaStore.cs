using Chapter4.PizzaStores.IngredientFactories;
using Chapter4.PizzaStores.Pizzas;

namespace Chapter4.PizzaStores.PizzaStores;

// example of Factory Method
// Each subclass of PizzaStore Decides which concrete class to instantiate
// The ChicagoPizzaStore SubClass instantiates only Chicago Style Pizzas
public class ChicagoPizzaStore: PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        switch(type)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Style Clams Pizza";
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "ChicagoPepperoni Pizza";
                break;
        }

        return pizza;
    }
}
