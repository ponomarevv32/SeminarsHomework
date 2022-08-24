/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
 и на выходе показывает вторую цифру этого числа.*/
/*
 * int Calculate(int num){
    int number1 = num / 10;
    int result = number1 % 10;
    return result;
}
Console.WriteLine("Введите 3-х значное число");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая цифра числа" +  Calculate(num));
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.*/



/*
int NumberThird(int num)
{
    while (num >= 1000) num /=10;
    num %= 10;
    return num;
}

int num = new Random().Next(0,999999999);
Console.WriteLine("число"+ num);
if (num > 99)
{
    Console.WriteLine(NumberThird(num));
}
else
{
    Console.WriteLine("третьей цифры нет");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.


void DayWeekend(int day)
{
if (day==6||day==7){
    Console.WriteLine("да");
}
    else
    {
        Console.WriteLine("нет");
    }
}
Console.WriteLine("введите число");
int day=Convert.ToInt32(Console.ReadLine());
if (day > 7)
{
    Console.WriteLine("такого дня недели нет"); 
}
else
{
    DayWeekend(day);

}
