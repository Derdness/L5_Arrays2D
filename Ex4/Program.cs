/*Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца.
*/

int[,] arr = Gen2DArray(10, 6);
Print2DArray(arr);
Console.WriteLine("=>");
Print2DArray(MinorOfLesserElement(arr));


/// <summary>
/// Вывод матрицы без строки и столбца, содержащих
/// её минимальный элемент.
/// </summary>
/// <param name="arr">Рассматриваемый массив</param>
int[,] MinorOfLesserElement(int[,] arr)
{
    int min = int.MaxValue; //Чтобы любое число из нашего массива не оказалось больше min
    int min_i = 0;
    int min_j = 0;
    for(int i=0;i<arr.GetLength(0);i++) //Находим индексы минимального элемента
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            if(min > arr[i, j])
            {
                min = arr[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }

    Console.WriteLine($"Минимальный элемент: ({min_i},{min_j}) - {min}");

    int[,] result = new int[arr.GetLength(0)-1,arr.GetLength(1)-1]; //Массив меньше на 1 строку и столбец
    for(int i=0, old_i=0;i<result.GetLength(0);i++, old_i++) //Проходим одновременно по двум массивам
    {                   //Если достигаем позиции минимального элемента, пропускаем его в старом массиве
        if(i == min_i)
            old_i++;
        for(int j=0, old_j=0;j<result.GetLength(1);j++, old_j++)
        {
            if(j == min_j)
                old_j++;
            result[i,j] = arr[old_i,old_j];
        }
    }
    return result;
}

/// <summary>
/// Создать двумерный массив целых чисел
/// и заполнить трёхзначными числами
/// </summary>
/// <param name="row">Количество строк.</param>
/// <param name="col">Количество столбцов.</param>
int[,] Gen2DArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rng = new Random();
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
            arr[i,j] = rng.Next(100, 1000);

    return arr;
}

/// <summary>
/// Вывести в консоли переданный двумерный массив
/// </summary>
/// <param name="arr">Массив для вывода в консоль</param>
void Print2DArray(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
        {
            if(j < arr.GetLength(1)-1)
                Console.Write($"{arr[i,j]} ");
            else
                Console.WriteLine(arr[i,j]);
        }
            
}
