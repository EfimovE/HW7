// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt (int row, int col, int min, int max)
{
    int[,] matrix = new int [row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            matrix[i , j] = rnd.Next (min, max + 1);
        }
    }
    return matrix;
}

double [] AverageCol (int[,] array2D)
{
    int size = array2D.GetLength(1);
    double[]array = new double[size]; 
    double sum = 0;
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i,j]; 
        }
    array[j] = Math.Round(sum / array2D.GetLength(0) , 1);
    sum = 0;
    }
    return array;
}

void PrintArray (double[]array) // метод для вывода в консоль
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}.");
}

// Метод для вывода в консоль двумерного массива.
void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write (" [ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write ($"{matrix [i,j], 3}, ");
            else Console.Write($"{matrix [i,j],3}");
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
int [,] array2D = CreateMatrixRndInt (m, n, minElem, maxElem);
PrintMatrix (array2D);
double[]arrayAverageCol = AverageCol (array2D);
PrintArray(arrayAverageCol);