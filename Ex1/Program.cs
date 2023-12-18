/*Задача 1: Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
*/

int[,] arr = gen2DArray(7, 8);
print2DArray(arr);
int row;                //Номер строки
int col;                //Номер столбца
bool notDone = true;
try
{
    Console.Write("Введите индекс строки: ");
    row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    col = Convert.ToInt32(Console.ReadLine());
    Console.Write($"({row},{col})  =>  {arr[row,col]}");
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("Такого элемента нет.");
}
catch(FormatException)
{
    Console.WriteLine("Индекс - целое число.");
}
catch(Exception e)
{
    Console.WriteLine(e);
}





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


