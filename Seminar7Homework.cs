//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray(int rows, int cols )
{
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] =( new Random().Next(-10, 10) );
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:f1}", array[i, j]);
        }
        Console.WriteLine();
    }
}
Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
*/

//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
/*
void Calc(int[,] array,int rows,int cols)
{

    if (rows <= array.GetLength(0) && cols <= array.GetLength(1))
        Console.Write(array[rows, cols] + " ");
    else Console.WriteLine("Такогоэлемента нет");
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.Write("Input numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Calc(array,m,n);

*/
//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
void SumCols(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine(sum / array.GetLength(0));
    }
}
Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
SumCols(array);
*/