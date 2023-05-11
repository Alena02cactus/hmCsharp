// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next((int)min, (int)(max + 1));
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double SumElements(double[] arr)
{
    double sum = 0;
    double min = arr[0];
    double max = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
        sum = min + max;
    }
    return sum;
}

double[] array = CreateArrayRndDouble(5, 1.0, 10.0);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
double sumElements = SumElements(array);

Console.WriteLine($"Сумма минимального и максимального числа в массиве равно {sumElements}");
