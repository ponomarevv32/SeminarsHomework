//Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
 //Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string RecursMToN(int numM,int numN)
{
    if (numM == numN) return numN.ToString();
    else if (numM >= numN) return numN + " " + RecursMToN(numM, numN + 1);
    return numM + " " + RecursMToN(numM + 1, numN);
}
int numM = ReadData("Введите число N:");
int numN = ReadData("Введите число N:");
string outLine1 = RecursMToN(numM,numN);
PrintData("Числа от M до N: ", outLine1);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int RecursSum(int numM, int numN)
{
    if (numM >= numN) return numN;
    return numM + RecursSum(numM + 1, numN);
}
int numM = ReadData("Введите число N:");
int numN = ReadData("Введите число N:");
string sum = RecursSum(numM, numN).ToString();

PrintData("сумма чисел от М до N: " ,sum);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunc(m - 1, 1);
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
int m = ReadData("Введите число N:");
int n= ReadData("Введите число N:");
string s = AkkermanFunc(m, n).ToString();
PrintData("sum", s);
*/