/* Задача 55: Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно,
программа должна вывести сообщение для пользователя. */
//  1. Функция получения массива
//  2. Функция написания строк и столбцов
//  3. Функция замены строк на столбцы
//  4. Функция печати

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void reverse(int[,] arr)
{
    int[,] arrayReverse = new int[arr.GetLength(1), arr.GetLength(0)];

    for (int i = 0; i < arrayReverse.GetLength(0); i++)
    {
        for (int j = 0; j < arrayReverse.GetLength(1); j++)
        {
            arrayReverse[i, j] = arr[j, i];
        }
    }
    PrintArray(arrayReverse);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetArray(2, 5);
PrintArray(matrix);
reverse(matrix);
