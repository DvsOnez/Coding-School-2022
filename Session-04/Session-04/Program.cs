using Session_04;
using System.Text;
// 1 
Console.Write("Enter a Name : ");
String name = Console.ReadLine();
var c1 = new Reverser();


string reversedname = c1.Reverse(name);
Console.WriteLine(reversedname);

// 2
Console.WriteLine("Give an integer Number : ");
string input = Console.ReadLine();  
int n = Convert.ToInt32(input);

var c2 = new SumAndProduct();


Console.WriteLine("The sum is "+ c2.GetSum(n));

Console.WriteLine("the Product is : " + c2.GetProduct(n));
//3
Console.Write("Please give a number");

Console.Write("Please write a positive number: ");
int n2 = Convert.ToInt32(input);
var primesCalculator = new PrimeCalculator(n2);

primesCalculator.DisplayPrimes();
Console.WriteLine();




//4

var array1 = new int[] { 2, 4, 9, 12 };
var array2 = new int[] { 1, 3, 7, 10 };
var multiplier = new ArrayMultiplier(array1, array2);
int[] result =  multiplier.Results();

Console.Write("the results are : " + result);




















