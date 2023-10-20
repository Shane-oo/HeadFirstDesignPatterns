using Chapter2.WeatherStation.ObserverPattern;
using Chapter2.WeatherStation.ObserverPattern.Displays;

WeatherData weatherData = new();

var currentDisplay = new CurrentConditionsDisplay(weatherData);
var heatIndexDisplay = new HeatIndexDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.3f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.RemoveObserver(currentDisplay);
weatherData.SetMeasurements(78, 90, 29.2f);
weatherData.SetMeasurements(78, 90, 25.2f);
