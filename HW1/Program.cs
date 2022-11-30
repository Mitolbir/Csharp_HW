// Домашнее задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("First number is bigger");
}
else
{
    Console.WriteLine("Second number is bigeer");
}
*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
else
{
    max = num1;
}
if (num3 > max)
{
    max = num3;
}
else
{
    max = num1;
}

Console.Write("Your max number is: " + max);
*/

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is not even");
}
*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current++;
     }
    else 
    {
        current++;
    }
*/