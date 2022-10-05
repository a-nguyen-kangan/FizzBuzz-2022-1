// Read in inputs
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
System.Console.WriteLine("------- Version 1 --------");
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

// Version 2 - using modulus
System.Console.WriteLine("------- Version 2 --------");
var counter2 = 1;
var line = "";

while (counter2 <= maxNum) {
    if (counter2 % fizzNum == 0) {
        line += "Fizz";
    }
    if (counter2 % buzzNum == 0) {
        line += "Buzz";
    }
    if (line == "") {
        line = counter2.ToString();
    }
    System.Console.WriteLine(line);
    line = "";
    counter2++;
}