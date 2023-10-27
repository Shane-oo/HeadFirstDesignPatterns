using Chapter9.IteratorPattern;
using Chapter9.IteratorPattern.Menus;

var pancakeHouseMenu = new PancakeHouseMenu();

var dinerMenu = new DinerMenu();

var cafeMenu = new CafeMenu();

var waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

waitress.PrintMenu();
