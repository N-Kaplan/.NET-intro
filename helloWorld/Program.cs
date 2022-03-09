// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hi {name}!");
Console.WriteLine($"Pick a number, {name}.");

string num = Console.ReadLine();

int intNum;

bool isParsable = Int32.TryParse(num, out intNum);
if (isParsable)
    Console.WriteLine($"You picked {intNum}.");
else
{
    intNum = 42;
    Console.WriteLine($"You picked and invalid number, I picked {intNum} for you!");
}

Console.WriteLine($"Do you want to know what the third power of {intNum} is? (y/n)");
string choice = Console.ReadLine();
int pow = intNum*intNum*intNum;

switch (choice)
{
    case "y":
    case "yes":
        Console.Write($"The third power of {intNum} is {pow}. You're welcome!");
        break;
    case "n":
    case "no":
        Console.Write("Ok, have a nice day!");
        break;
    default:
        Console.Write($"That was not a valid answer. Just in case, the third power of {intNum} is {pow}. See you!");
        break;
}