// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Integer values
int integer_A = 10;
int integer_B = 20;

// Call arithmetic functions and print results
Console.WriteLine($"Addition: {Add(integer_A, integer_B)}");
Console.WriteLine($"Subtraction: {Subtract(integer_A, integer_B)}");
Console.WriteLine($"Multiplication: {Multiply(integer_A, integer_B)}");
Console.WriteLine($"Division: {Divide(integer_A, integer_B)}");
Console.WriteLine($"Modulus: {Modulus(integer_A, integer_B)}");

// Functions
int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => b != 0 ? a / b : 0;
int Modulus(int a, int b) => b != 0 ? a % b : 0;


while (true)
{
    Console.WriteLine("\n--- Simple Calculator ---");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Modulus");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option (1-6): ");

    var choice = Console.ReadLine();

    if (choice == "6") break;

    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case "1": Console.WriteLine($"Result: {a + b}"); break;
        case "2": Console.WriteLine($"Result: {a - b}"); break;
        case "3": Console.WriteLine($"Result: {a * b}"); break;
        case "4": Console.WriteLine(b != 0 ? $"Result: {a / b}" : "Cannot divide by zero"); break;
        case "5": Console.WriteLine(b != 0 ? $"Result: {a % b}" : "Cannot divide by zero"); break;
        default: Console.WriteLine("Invalid choice."); break;
    }
}
