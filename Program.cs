var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// The browser calls this endpoint; the math happens here in C#
Console.WriteLine("===== SIMPLE CALCULATOR =====");

Console.Write("Enter your first number: ");
decimal input1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter your second number: ");
decimal input2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"First number: {input1}");
Console.WriteLine($"Second number: {input2}");

if (input1 >= 0 && input2 >= 0)
{
    Console.WriteLine("\nChoose an operation:");
    Console.WriteLine("1. Addition (+)");
    Console.WriteLine("2. Subtraction (-)");
    Console.WriteLine("3. Multiplication (*)");
    Console.WriteLine("4. Division (/)");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    decimal result = 0;

    switch (choice)
    {
        case 1:
            result = input1 + input2;
            Console.WriteLine($"Result = {result}");
            break;

        case 2:
            result = input1 - input2;
            Console.WriteLine($"Result = {result}");
            break;

        case 3:
            result = input1 * input2;
            Console.WriteLine($"Result = {result}");
            break;

        case 4:
            if (input2 != 0)
            {
                result = input1 / input2;
                Console.WriteLine($"Result = {result}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            break;

        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}
else
{
    Console.WriteLine("Numbers cannot be negative!");
}record CalcRequest(decimal A, decimal B, string Op);
