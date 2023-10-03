// See https://aka.ms/new-console-template for more information

using Chapter5.ChocoHolic;

var chocolateBoiler = ChocolateBoiler.GetInstance();

Console.WriteLine(chocolateBoiler.Empty);

var chocolateBoiler2 = ChocolateBoiler.GetInstance();

chocolateBoiler2.Empty = false;

Console.WriteLine(chocolateBoiler.Empty);
Console.WriteLine(chocolateBoiler2.Empty);