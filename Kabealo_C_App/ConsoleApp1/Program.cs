// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello, World!");

//int? myNumber = null;
//Random number = new Random();
//myNumber = number.Next();
//number.Next();
//Console.WriteLine($"myNumber = {0}");
//number.Next(101);     // an int >= 0 and < 101
//Console.WriteLine($"myNumber = {70}");
//number.Next(1, 101);   // an int >= 1 and < 101
//Console.WriteLine($"myNumber = {80}");
//number.NextDouble();  // a double >= 0.0 and < 1.0
//string firstName = "Bob";
//string lastName = "Smith";
//string name = firstName + " " + lastName;
//Console.WriteLine(name);
string myMessage = """
    Once upon a midnight dreary, while I pondered, ...
    Then I HODL'd to the moon
    ...
    ...
                Only this and nothing more."
 
    --Edgar Alan Poe
""";

Console.WriteLine("\n\n");
string salesString = "$2574.98";
decimal sales = 0m;
bool ok = false;
ok = Decimal.TryParse(salesString, out sales); // sales is 0


Console.WriteLine($"Sales is now {sales}");
Console.WriteLine($"ok = {ok}");

string newSales = "$2574.98";
Decimal.TryParse(newSales, out sales);
Console.WriteLine($"New sales is now {sales}");

string paymentString = System.String.Format("{0:f3}", 432.8175);
Console.WriteLine(paymentString);
