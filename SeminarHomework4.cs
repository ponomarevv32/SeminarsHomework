//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

/*int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
        result *= num1;


    return result;
}
Console.WriteLine("Введите число 1 и 2");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(num1, num2));
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

/*

int Sum(int num)
{

    int summary = 0;
    for (; num > 0; num /= 10)
    {
        summary += num % 10;
    }
    return summary;
}

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(num));
*/




//Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] =Convert.ToInt32(Console.ReadLine());
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

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(size));
*/
