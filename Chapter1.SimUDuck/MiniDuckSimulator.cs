using Chapter1.SimUDuck.Ducks;
using Chapter1.SimUDuck.Ducks.Behaviours.FlyBehaviour;

Duck mallard = new MallardDuck();
mallard.PerformFly();
mallard.PerformQuack();

Duck model = new ModelDuck();
model.SetFlyBehaviour(new FlyRocketPowered());
model.PerformFly();
