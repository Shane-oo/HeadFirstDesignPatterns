using Chapter1.SimUDuck.StrategyPattern.Ducks;
using Chapter1.SimUDuck.StrategyPattern.Ducks.Behaviours.FlyBehaviour;

Duck mallard = new MallardDuck();
mallard.PerformFly();
mallard.PerformQuack();

Duck model = new ModelDuck();
model.SetFlyBehaviour(new FlyRocketPowered());
model.PerformFly();
