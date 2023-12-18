/*Задача 3: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
*/

int[,] arr = Gen2DArray(7, 8);
Print2DArraySummedRows(arr);
Console.WriteLine("=>");
Console.WriteLine($"Строка с индексом {LesserSumRow(arr)}");



/// <summary>
/// Создать двумерный массив целых чисел
/// и заполнить его цифрами
/// </summary>
/// <param name="row">Количество строк.</param>
/// <param name="col">Количество столбцов.</param>
int[,] Gen2DArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rng = new Random();
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
            arr[i,j] = rng.Next(1, 10);

    return arr;
}

/// <summary>
/// Вывести в консоли переданный двумерный массив,
/// справа от каждой строки выводя сумму её элементов.
/// </summary>
/// <param name="arr">Массив для вывода в консоль</param>
void Print2DArraySummedRows(int[,] arr)
{
    int sum;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        sum = 0;
        for(int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write($"{arr[i,j]} ");
            sum += arr[i, j];
        }
        Console.WriteLine($"  {sum}");
    }    
}

/// <summary>
/// Поиск индекса строки с наименьшей суммой элементов.
/// Находит индекс первой наименьшей строки.
/// </summary>
/// <param name="arr">Рассматриваемый массив</param>
int LesserSumRow(int[,] arr)
{
    int sum;
    int min = 0;
    int min_i = 0;
    for(int i=0;i<arr.GetLength(0);i++)
    {   
        sum = 0;
        for(int j=0;j<arr.GetLength(1);j++)
        {
            sum += arr[i, j];
        }
        if(i == 0)
            min = sum;
        else if(min > sum)
        {
            min = sum;
            min_i = i;
        }
    }
    return min_i;
}