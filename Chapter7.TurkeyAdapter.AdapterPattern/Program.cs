
using Chapter7.TurkeyAdapter.AdapterPattern;

var turkey = new WildTurkey();
var turkeyAdapter = new TurkeyAdapter(turkey);

TestDuck(turkeyAdapter);
return;

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}