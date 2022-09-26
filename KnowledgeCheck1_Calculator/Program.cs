using KnowledgeCheck1_Calculator;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();
{ 
    Console.WriteLine("Enter 2 integers to solve for");
var Number1 = Console.ReadLine();
var Number2 = Console.ReadLine();

switch (input)
{
    case "1":
        if (int.TryParse(Number1, out int addNumOne) && int.TryParse(Number2, out int addNumTwo))
        {
            Console.Write($"{Number1} + {Number2} =  ");
            Console.Write(calculator.Add(addNumOne, addNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "2":
 if (int.TryParse(Number1, out int subNumOne) && int.TryParse(Number2, out int subNumTwo))
        {
            Console.Write($"{Number1} - {Number2} =  ");
            Console.Write(calculator.Subtract(subNumOne, subNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "3":
if (int.TryParse(Number1, out int mulNumOne) && int.TryParse(Number2, out int mulNumTwo))
        {
            Console.Write($"{Number1} * {Number2} =  ");
            Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "4":
if (double.TryParse(Number1, out double divNumOne) && double.TryParse(Number2, out double divNumTwo))
        {
            Console.Write($"{Number1} / {Number2} =  ");
            Console.Write(calculator.Divide(divNumOne, divNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;
        break;

    default:
        Console.WriteLine("Unknown input");
        break;

}
    Console.WriteLine();
        Console.WriteLine("Press enter to close...");
    Console.ReadLine();
}
