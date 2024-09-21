using System.Globalization;

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber  = int.Parse(Console.ReadLine());
int thirdNumber  = int.Parse(Console.ReadLine());

bool IsAscending = firstNumber < secondNumber && secondNumber < thirdNumber;
bool IsDescending = firstNumber > secondNumber && secondNumber > thirdNumber;

if (IsAscending)
{
    Console.WriteLine("Ascending");
}
else if (IsDescending)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
