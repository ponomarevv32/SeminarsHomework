/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.*/

/*
int num1, num2;
Console.WriteLine("Введите 1 число");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1 число");
num2 =Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("max=" + num1);
    Console.WriteLine("min=" + num2);
}
else if(num1 < num2)
{
    Console.WriteLine("max=" + num2);
    Console.WriteLine("min=" + num1);}
else
{
    Console.WriteLine("числа равны");
}
*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

int num1, num2, num3, max = 0;
Console.WriteLine("Введите 1 число");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1 число");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
num3 = Convert.ToInt32(Console.ReadLine());
if (num1>max)
{
    max = num1;
}
else if (num2 > max)
{
    max = num2;
}
else if (num3 > max)
{
    max = num3;
}
Console.WriteLine(max);*/



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).

int num;
Console.WriteLine("Введите  число");
num = Convert.ToInt32(Console.ReadLine());
 
if (num%2==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
} 
*/



/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.


int N,num1=1;
Console.WriteLine("Введите  число");
N = Convert.ToInt32(Console.ReadLine());
while (num1 <= N)
{
    num1++;
    if (num1 % 2 == 0)
    {
        Console.Write(num1+",");
    }

}
*/

