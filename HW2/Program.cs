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
или сообщает, что третьей цифры нет. 

int ThirdNum(int num)
{
    if (num < 100)
    {
        num = -1;
    }
    else
    {
        if (num < 1000)
        {
            num = num % 10;
        }
        else
        {
        while (num > 999)
        {
            num = num / 10;
        }
        if (num < 1000)
        {
            num = num % 10;
        }
        }
    }
    return num;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int newNum = ThirdNum(number);

if (newNum == -1)
{
    Console.WriteLine("There is no third digit in your number");
}
else
{
    Console.WriteLine($"Your third-digit number is {newNum}");
}
*/

