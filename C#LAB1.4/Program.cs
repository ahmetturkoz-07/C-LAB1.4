Console.Write("Enter a 3-digit number: ");
int number = int.Parse(Console.ReadLine()!);

int hundreds = number / 100;
int tens = (number / 10) % 10;
int ones = number % 10;
int sum = hundreds + tens + ones;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");
Console.WriteLine($"Sum of digits: {sum}");

if (number%2 == 0)
{
    Console.WriteLine($"{number} is even");
}
else
{
    Console.WriteLine($"{number} is odd");
}

if (hundreds == ones)
{
    Console.WriteLine("First and last digits are equal");
}
else
{
    Console.WriteLine("First ans last digits are not equal");
}