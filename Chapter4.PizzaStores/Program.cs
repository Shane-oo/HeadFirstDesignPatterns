// See https://aka.ms/new-console-template for more information

using Chapter4.PizzaStores;
using Chapter4.PizzaStores.PizzaStores;

var nyStore = new NYPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

Pizza pizza =nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan Ordered a {pizza.Name}");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}");