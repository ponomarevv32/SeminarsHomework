
/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.12821*/
/*void Func(int a)
{
    int num1 = a / 10000;
    int num2 = a / 1000;
    int num4 = a / 10;
    num4 = num4 % 10;
    int num5 = a % 10;
    if (num1 == num5 || num2 == num4)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("неправильное число");
}
else
{
    Func(number);
}
*/


//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве

 double ras(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int sum1 = x2 - x1;
    sum1=sum1*sum1;
    int sum2= y2 - y1;
    sum2=sum2^2;
    int sum3= z2 - z1;
    sum3=sum3^2;
    double result=sum1 + sum2+sum3;
    result = Math.Sqrt(result);
    return result;

}
Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2ой точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ras( x1,  y1,  z1,  x2,  y2, z2));

  


//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

/*void Multiple (int n)
{
    int i = 1;
    while(i <= n)
    {
        int result=i*i*i;
        i++;
        Console.WriteLine(result);
       
    }
   
}
Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
Multiple(n);
*/