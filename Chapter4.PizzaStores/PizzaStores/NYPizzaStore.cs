using Chapter4.PizzaStores.IngredientFactories;
using Chapter4.PizzaStores.Pizzas;

namespace Chapter4.PizzaStores.PizzaStores;

// example of Factory Method
// Each subclass of PizzaStore Decides which concrete class to instantiate
// The NYPizzaStore SubClass instantiates only New York Style Pizzas
public class NYPizzaStore: PizzaStore
{
    #region Private Methods

    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        switch(type)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clams Pizza";
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "New York Pepperoni Pizza";
                break;
        }

        return pizza;
    }

    #endregion
}
