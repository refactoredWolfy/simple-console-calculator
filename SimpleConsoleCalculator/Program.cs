//Learning project based on a Udemy C#/.Net fundamentals course


Console.WriteLine("Hello");
Console.WriteLine("Input your first number");
var inputNumberOne = Console.ReadLine();
var numberOne = int.Parse(inputNumberOne);

Console.WriteLine("Input your second number");
var inputNumberTwo = Console.ReadLine();
var numberTwo = int.Parse(inputNumberTwo);

Console.WriteLine("What do you want to do with these numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var operationInput = Console.ReadLine().ToLower();

switch (operationInput)
{

    case "a":
        Calculate(numberOne, numberTwo, "+");
        break;
    case "s":
        Calculate(numberOne, numberTwo, "-");
        break;
    case "m":
        Calculate(numberOne, numberTwo, "*");
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;



}

Console.WriteLine("Press any key to close the app");
Console.ReadKey();

void Calculate(int numberOne, int numberTwo, string operation)
{

    int result;
    if (operation == "+")
    {
        result = numberOne + numberTwo;
    }
    else if (operation == "-")
    {
        result = numberOne - numberTwo;
    }
    else if (operation == "*")
    {
        result = numberOne * numberTwo;
    }
    else
    {
        return;
    }

    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
}

