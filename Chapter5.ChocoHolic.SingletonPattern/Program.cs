using Chapter5.ChocoHolic.SingletonPattern;

var chocolateBoiler = ChocolateBoiler.GetInstance();

Console.WriteLine(chocolateBoiler.Empty);

var chocolateBoiler2 = ChocolateBoiler.GetInstance();

chocolateBoiler2.Empty = false;

Console.WriteLine(chocolateBoiler.Empty);
Console.WriteLine(chocolateBoiler2.Empty);
                                                                                           