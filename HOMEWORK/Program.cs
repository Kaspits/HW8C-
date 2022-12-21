/* Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// int[,] InitArray(int a, int b)
// {
//     int[,] array = new int[a, b];
//     Random rnd = new Random();
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
//     return array;
// }

// void SortLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] array = InitArray(3, 4);
// PrintArray(array);
// SortLower(array);
// Console.WriteLine();
// PrintArray(array);

//................................................................................................................................
/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

// int[,] InitArray(int a, int b, int min, int max)
// {
//     int[,] array = new int[a, b];
//     Random rnd = new Random();
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j < array.GetLength(1) - 1)
//                 Console.Write($"{array[i, j], 1}|");
//             else
//                 Console.Write($"{array[i, j], 1}");
//         }
//         Console.WriteLine("|");
//     }
//     Console.WriteLine();
// }

// void SumStringArray(int[,] array)
// {
//     int index = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         Console.WriteLine($"Сумма {i + 1} строки = {sum}");
//         if (i == 0)
//             minsum = sum;
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
//     string line = string.Empty;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         line += array[index, j] + " ";
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
// }

// int[,] array = InitArray(3, 4, 0, 9);
// PrintArray(array);
// SumStringArray(array);

//.....................................................................................................
/* Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Random rnd = new Random();
int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 1}|");
            else
                Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");
    }
}
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

int[,] array2D = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
int[,] matrix = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(DivMatrix(array2D, matrix));
Console.ReadLine();
