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
//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] SortArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = array.GetLength(1)-1 ; j > i; j--)
                if (array[i,j] > array[i,j-1])
                {
                    int tmp = array[i,j];
                    array[i,j] = array[i,j - 1];
                    array[i,j - 1] = tmp;
                }
        } 
       
    }
    return array;
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] Numbers= CreateRandom2dArray(rows,  cols,  min,  max);
Show2dArray(Numbers);
Console.WriteLine();
int[,]array = SortArray(Numbers);
Show2dArray(array);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
/*
void SumArray(int[,] array)
{
    int num=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (sum < minSum) minSum = sum;
            num = i;
        }
    }
    Console.Write($"m { num}");
}
Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] Numbers = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(Numbers);
Console.WriteLine();
SumArray(Numbers);
*/



//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] Spiral()
       {
           var result = new int[4, 4];
           int i = 1;
           for (int p = 0; p < 2; p++)
           {
               for (int j = p; j < 4 - p; j++)
                   result[p, j] = i;
               for (int j = p; j < 4 - p; j++)
                   result[4 - p - 1, j] = i;
               for (int k = p + 2; k < 4 - p - 1; k++)
                   result[i, p] = i;
               for (int k = p + 1; k < 4 - p - 1; k++)
                   result[k, 4 - p - 1] = i;
               i = 1 - i;
               result[p + 1, p] = i;
           }
           return result;
}
int[,] Numbers = Spiral();
Show2dArray(Numbers);
Console.WriteLine();
*/
