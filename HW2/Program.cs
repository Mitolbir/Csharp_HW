/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

int SecondNum(int num)
{

    int sec = num % 100 / 10;

    return sec;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int newNum = SecondNum(number);

Console.WriteLine($"New version of a number {number} is {newNum}");

Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

