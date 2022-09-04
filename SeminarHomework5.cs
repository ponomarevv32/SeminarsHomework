//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.


/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        
        array[i] = new Random().Next(100,1000) ;
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int Number(int[] array)
{
    int result = 0;
    for(int i= 0; i < array.Length; i++)
    {
        if(array[i]%2== 0)
       
        {
            result++;
        }
    }
    return result;
}
Console.WriteLine("Введите размер массива");
int size=Convert.ToInt32(Console.ReadLine());
int[] array=(CreateArray(size));
ShowArray(array);
Console.WriteLine(Number(array));

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int Sum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
   return sum;
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array=(CreateArray(size));
ShowArray(array);
Console.WriteLine(sum(array));
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int MaxNumber(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(max<array[i])
            max = array[i];
    }
    return max;
}
int MinNumber(int[] array)
{
    int min= array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = (CreateArray(size));
ShowArray(array);
Console.WriteLine(MaxNumber(array)-MinNumber(array));
*/

