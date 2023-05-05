// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int sum = 0;
    int numForSum = 0;
    while (num > 0)
    {
        numForSum = num % 10;
        sum = sum + numForSum;
        num = num / 10;
    }
    return sum;
}


int digitSum = DigitSum(number);
Console.WriteLine($"{digitSum}");
