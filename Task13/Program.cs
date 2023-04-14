// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdNumber = 0;
do
{
    number = number / 10;
} while (number > 1000);
if (number > 100 && number < 1000)
{
    ThirdNumber = number % 10;
    Console.Write(ThirdNumber);
}
else
{
    Console.Write("третьей цифры нет");
}
