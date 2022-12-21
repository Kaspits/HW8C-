/* Задача 60. ...Сформируйте трёхмерный массив из
неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// Console.WriteLine($"Введите размер массива X x Y x Z: ");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void CreateArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

//..................................................................................................

/* Задача 62. Напишите программу,
которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0,
        j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do
        {
            array[i, j++] = value++;
        } while (++k < n - 1);
        for (k = 0; k < n - 1; k++)
            array[i++, j] = value++;
        for (k = 0; k < n - 1; k++)
            array[i, j--] = value++;
        for (k = 0; k < n - 1; k++)
            array[i--, j] = value++;
        ++i;
        ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
