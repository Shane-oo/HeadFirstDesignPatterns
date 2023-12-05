// See https://aka.ms/new-console-template for more information

using Chapter12.DuckReunion.CompoundPattern;
using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

var simulator = new DuckSimulator();
var duckFactory = new CountingDuckFactory();

simulator.Simulate(duckFactory);