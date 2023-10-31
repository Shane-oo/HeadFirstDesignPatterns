using Chapter9.IteratorPattern;
using Chapter9.IteratorPattern.Menus;

var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
var dinerMenu = new Menu("DINER MENU", "Lunch");
var cafeMenu = new Menu("CAFE MENU", "Dinner");
var dessertMenu = new Menu("Dessert Menu", "Dessert");

var allMenus = new Menu("ALL MENUS", "All menus combined");

allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

// add menu items 
dinerMenu.Add(new MenuItem("Pasta","Spaghetti Pasta",true,3.89));

dinerMenu.Add(dessertMenu);

dessertMenu.Add(new MenuItem("Apple Pie","Apple With with ice cream",true,1.59));

// add more items here

var waitress = new Waitress(allMenus);

waitress.PrintMenu();
