//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2   -0,2
// 1   -3,3   8   -9,9
// 8   7,8   -7,1  9

double[,] CreateMatrixRndInt(double rows, double columns, double min, double max)
{
    //                        0       1
    double[,] matrix = new double[rows, columns]; // 3, 4
    Random rnd = new Random();

    for (double i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) = 3
    {
        for (double j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (double[,] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine(" |");
    }
}

double[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
