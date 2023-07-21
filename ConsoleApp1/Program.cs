// See https://aka.ms/new-console-template for more information

using System.Data;

using ConsoleApp1;

Console.WriteLine("Dunder COMMANDS");
Console.WriteLine("how many reams?");
var input = Console.ReadLine();
Console.WriteLine("unit price of the ream?");
var unitePriceInput = Console.ReadLine();
Console.WriteLine("in which state?");
var state = Console.ReadLine();

var numberOfReams = Int32.Parse(input);
double.TryParse(unitePriceInput, out var pricePerUnitFreeOfTax);

var price = numberOfReams * pricePerUnitFreeOfTax;

var discount = Purchase.ApplyDiscount(price);
var tax = Purchase.ApplyTva(state);

var total = price - (price * discount / 100);
var totalTTC = total + (total * tax / 100 );
//var discountedPrice = price

Console.WriteLine($"your free of tax price is : {price} $, and your discount is {discount}%");
Console.WriteLine($"your TOTAL  tax price is {totalTTC}");@


