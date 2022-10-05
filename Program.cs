// Read in inputs
var inpMaxNum = "";
var inpFizzNum = "";
var inpBuzzNum = "";

var maxNum = 0;
var fizzNum = 0;
var buzzNum = 0;

System.Console.Write("Enter number to count to: ");
while (!int.TryParse(Console.ReadLine(), out maxNum)) {
    System.Console.WriteLine("Not a valid integer.  Please enter an integer");
}

System.Console.Write("Enter number for Fizz: ");
while (!int.TryParse(Console.ReadLine(), out fizzNum)) {
    System.Console.WriteLine("Not a valid integer.  Please enter an integer");
}

System.Console.Write("Enter number for Buzz: ");
while (!int.TryParse(Console.ReadLine(), out buzzNum)) {
    System.Console.WriteLine("Not a valid integer.  Please enter an integer");
}

System.Console.WriteLine(maxNum);

// Version 1 - using multiple counters

