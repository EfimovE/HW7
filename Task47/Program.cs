// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Метод для создания двумерного массива.

double[,] CreateMatrixRndInt (int row, int col, double min, double max)
{
    double[,] matrix = new double [row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            matrix[i , j] = Math.Round(rnd.NextDouble() * (max-min) + min, 1);
        }
    }
    return matrix;
}

// Метод для вывода в консоль двумерного массива.
void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write (" [ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write ($"{matrix [i,j], 4}, ");
            else Console.Write($"{matrix [i,j], 4}");
        }
        Console.WriteLine (" ] ");
    }
}

Console.WriteLine("Введите количество строк и нажмите Enter.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов и нажмите Enter.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива и нажмите Enter.");
int minElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива и нажмите Enter.");
int maxElem = Convert.ToInt32(Console.ReadLine());
double [,] array2D = CreateMatrixRndInt (m, n, minElem, maxElem);
PrintMatrix (array2D);