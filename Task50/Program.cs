// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

// Метод для создания двумерного массива.
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