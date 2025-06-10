beggining:
//Initialisation variables and enter data
Console.Write("Enter first integet number: ");
bool isInt1 = Int32.TryParse(Console.ReadLine(), out int firstNumber);

Console.Write("Enter second integer number: ");
bool isInt2 = Int32.TryParse(Console.ReadLine(),out int secondNumber);

enteringOperation:
Console.Write("Enter mathematical operation (* , / , + , -): ");
string operation = Console.ReadLine();

//Check if data is correct
if (!(isInt1 && isInt2))
{
    Console.WriteLine("\nPlease, enter correct data\n");
	goto beggining;
}

//Do calculation
switch (operation)
{
	case "+":
        Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
		break;
	case "-":
		Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
		break;
	case "*":
		Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
		break;
	case "/" when secondNumber != 0:
		Console.WriteLine($"\n{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
		break;
	case "/" when secondNumber == 0:
		Console.WriteLine("\nOops, maybe you want to divide by zero.\nPlease, enter correct data\n");
		goto beggining;
	default:
        Console.WriteLine("\nOops, maybe you entered wrong operation.\nPlease, enter correct data\n");
		goto enteringOperation;
}