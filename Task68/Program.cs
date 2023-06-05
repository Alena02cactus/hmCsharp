// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое целое положительное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int functionAkkerman = Func(numberM, numberN);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Func(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Func(m - 1, 1);
  else return Func(m - 1, Func(m, n - 1));
}
