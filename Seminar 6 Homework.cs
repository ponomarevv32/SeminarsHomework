//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.




/*
int Count(int m, int[] array)
{
    int result = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            result++;
    }
    return result;
}
Console.WriteLine("Введите количество чисел");
int m=Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];
Console.WriteLine(Count(m, numbers));
*/




//Задача 43:Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void Number(int b1,int b2,int k1,int k2)
{
    double x= (b2 - b1) / (k1 - k2);
    double y= k1*x+b1;
    Console.WriteLine($"{x},{ y}");
}
Console.WriteLine("Введите число b1");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Number(b1, b2, k1, k2);
*/