/* Задача 57:
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных. */

// int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 };

// string arrayDictionary(int array)
// {
//     int countColumns = 1;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         for (int j = 1; j < array.Length; j++)
//         {
//             if (array[j] != array[i])
//             {
//                 countColumns++;
//             }
//         }
//     }
// }


int[] array = new int[] { 1, 9, 9, 0, 2, 8, 0, 9 };

Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 0; i < array.Length; i++)
{
    if (dic.ContainsKey(array[i]))
        dic[array[i]] = dic[array[i]] + 1;
    else
        dic.Add(array[i], 1);
}

foreach (var item in dic.OrderBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value}");
}
