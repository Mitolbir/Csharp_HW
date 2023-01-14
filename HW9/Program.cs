/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

void NatIn1N(int numN)
{
    if(numN > 1) 
    {
        Console.Write(numN + " ");
        NatIn1N(numN - 1);
    }
    if(numN < 1) 
    {
        Console.Write(numN + " ");
        NatIn1N(numN + 1);
    }
    if(1 == numN) Console.Write(numN + " ");
}

Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
NatIn1N(numN);
*/

/*
Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

int SumInMN(int numM, int numN)
{

    if(numM > numN) 
    {
        if(numM == numN)
        {
            return numN;
        }
    return numM + SumInMN(numM - 1, numN);
    }
    else
    {
        if(numM == numN)
        {
            return numM;
        }
    return numM + SumInMN(numM + 1, numN);
    }
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
SumInMN(numM, numN);

Console.Write(SumInMN(numM, numN));
*/

/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

int AkkInMN(int numM, int numN)
{

    if(numM == 0) return numN + 1;
    else if (numN == 0 && numM > 0) return AkkInMN(numM - 1, 1);
    else return AkkInMN(numM - 1, AkkInMN(numM, numN - 1));
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
AkkInMN(numM, numN);

Console.Write(AkkInMN(numM, numN));
*/