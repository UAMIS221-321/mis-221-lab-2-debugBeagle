//varibles 
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;

double totalSandwichCost = 0;
double totalToppingCost = 0;
double baseCost = 0;
double orderCost = 0;

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;


System.Console.WriteLine("how many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("how many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("How much tip would you like to leave?");
tip = double.Parse(Console.ReadLine());

System.Console.WriteLine("So its " + numberOfSandwiches + " sandwiches " + numberOfToppings + " toppings and a " + tip + " tip thank you ");

totalSandwichCost = numberOfSandwiches * COST_OF_SANDWICH;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

System.Console.WriteLine("Your total is $" + orderCost);


