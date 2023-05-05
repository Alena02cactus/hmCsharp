// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа:");
int pow = Convert.ToInt32(Console.ReadLine());

int result = NumberPow(number,pow);
Console.WriteLine($"Число {number} в степени {pow} = {result}");

int NumberPow(int num,int numPow)
{
    int power = 1;
    for (int i = 0; i < numPow; i++)
    {
        checked
        {
            power*= num; 
        }
    }
    return power;
}
