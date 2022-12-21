/* Задача 53: Задайте двумерный массив.
Напишите программу,
которая поменяет местами первую и последнюю строку массива.*/

//Функция получения числа
//Функция получения positive числа
//Функция получения массива
//Функция замены строк массива
// Функция печати массива
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

//Функция получения positive числа
int GetPositiveNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не to число");
        }
    }
    return result;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int[,] ArrayStringReplace(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                resultArray[i, j] = array[array.GetLength(0) - 1, j];
            }
            else if (i == array.GetLength(0) - 1)
            {
                resultArray[i, j] = array[0, j];
            }
            else
            {
                resultArray[i, j] = array[i, j];
            }
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}

int m = GetPositiveNumber("Enter m ");
int n = GetPositiveNumber("Enter n");
int minValue = GetNumber("Enter mimal value");
int maxValue = GetNumber("Enter maxmal value");
int[,] array = GetArray(m, n, minValue, maxValue);
PrintArray(array);
int[,] resultArray = ArrayStringReplace(array);
Console.WriteLine();
PrintArray(resultArray);
