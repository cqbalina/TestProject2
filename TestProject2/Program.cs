Console.WriteLine("Choose an operation: sum or product.");
Console.WriteLine("Enter 1 for sum or 2 for product:");

int choice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of elements:");

int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

Console.WriteLine("Enter the values:");

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Enter the value:");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    numbers[i] = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
}

// Variables for results
double sum = 0;
double product = 1;

// Sum calculation
if (choice == 1)
{
    for (int i = 0; i < size; i++)
    {
        sum = sum + numbers[i];
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The sum is: " + sum);
    Console.ResetColor();
}

// Product calculation
else if (choice == 2)
{
    for (int i = 0; i < size; i++)
    {
        product = product * numbers[i];
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The product is: " + product);
    Console.ResetColor();
}
else
{
    Console.WriteLine("Invalid choice. Try again.");
}