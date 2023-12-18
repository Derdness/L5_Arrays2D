/*Задача 2: Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
*/

int[,] arr = gen2DArray(7, 8); //Инициализируем двумерный массив
print2DArray(arr);             //Выводим его на печать
Console.WriteLine("=>");
SwapRows(arr, 0, arr.GetLength(0)-1); //Меняем местами первую и последнюю строки
print2DArray(arr);             //Выводим на печать изменённый массив


/// <summary>
/// Создать двумерный массив целых чисел
/// и заполнить его цифрами
/// </summary>
/// <param name="row">Количество строк.</param>
/// <param name="col">Количество столбцов.</param>
int[,] gen2DArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rng = new Random();
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
            arr[i,j] = rng.Next(1, 10);

    return arr;
}

/// <summary>
/// Вывести в консоли переданный двумерный массив
/// </summary>
/// <param name="arr">Массив для вывода в консоль</param>
void print2DArray(int[,] arr)
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

/// <summary>
/// Поменять местами две строки в данном двумерном массиве
/// </summary>
/// <param name="arr">Изменяемый массив</param>
/// <param name="first">Индекс первой строки</param>
/// <param name="second">Индекс второй строки</param>
void SwapRows(int[,] arr, int first, int second)
{
    int temp;
    for(int i=0;i<arr.GetLength(1);i++)
    {
        temp = arr[first, i];
        arr[first, i] = arr[second, i];
        arr[second, i] = temp;
    }

}