using Chapter9.IteratorPattern;
using Chapter9.IteratorPattern.Menus;

var pancakeHouseMenu = new PancakeHouseMenu();

var dinerMenu = new DinerMenu();

var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

waitress.PrintMenu();
