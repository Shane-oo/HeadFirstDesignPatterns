
using Chapter7.TurkeyAdapter;

var turkey = new WildTurkey();
var turkeyAdapter = new TurkeyAdapter(turkey);

TestDuck(turkeyAdapter);
return;

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}