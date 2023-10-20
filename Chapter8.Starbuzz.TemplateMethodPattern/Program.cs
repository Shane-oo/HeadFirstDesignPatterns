
using Chapter8.Starbuzz.TemplateMethodPattern;

var tea = new Tea();

tea.PrepareRecipe();

var coffee = new Coffee();
coffee.PrepareRecipe();

var coffeeHook = new CoffeeWithHook();
coffeeHook.PrepareRecipe();