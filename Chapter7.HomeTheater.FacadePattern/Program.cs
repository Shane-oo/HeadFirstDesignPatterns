// See https://aka.ms/new-console-template for more information

using Chapter7.HomeTheater.FacadePattern;
using Chapter7.HomeTheater.FacadePattern.SubSystem;

var amp = new Amplifier();
var tuner = new Tuner();
var player = new Player();
var projector = new Projector();
var lights = new TheaterLights();
var screen = new Screen();
var popCorn = new PopCornPopper();
var homeTheater = new HomeTheaterFacade(amp,tuner,player,projector,lights,screen,popCorn);

homeTheater.WatchMovie("Star Wars");