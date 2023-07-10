// See https://aka.ms/new-console-template for more information
using Bridge.Cuisines;
using Bridge.Foods;

Console.WriteLine("Hello, World!");

var ukrainianCuisine = new UkrainianCuisine();
var firstFood = new FirstFood(ukrainianCuisine);
firstFood.Cook();

var secondFood = new SecondFood(ukrainianCuisine);
secondFood.Cook();

var americanCuisine = new AmericanCuisine();
firstFood = new FirstFood(americanCuisine);
firstFood.Cook();

secondFood = new SecondFood(americanCuisine);
secondFood.Cook();

Console.ReadKey();