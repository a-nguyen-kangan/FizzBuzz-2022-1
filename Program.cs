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
var fizzCounter = 1;
var buzzCounter = 1;
var counter1 = 1;

while (counter1 <= maxNum) {
    if (fizzCounter == fizzNum && buzzCounter == buzzNum) {
        System.Console.WriteLine("FizzBuzz");
        fizzCounter = 1;
        buzzCounter = 1;
    }
    else if(fizzCounter == fizzNum) {
        System.Console.WriteLine("Fizz");
        fizzCounter = 0;
    } else if (buzzCounter == buzzNum) {
        System.Console.WriteLine("Buzz");
        buzzCounter = 0;
    } else {
        System.Console.WriteLine(counter1);
    }

    counter1++;
    fizzCounter++;
    buzzCounter++;
}
