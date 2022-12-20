/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

void UpNull(int size)
{
    int counter = 0;
    int upnull = 0;
    int number = 0;
        while (counter < size)
            {
                Console.Write("Input number: ");
                number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                        {
                            upnull++;
                            counter++;
                        }
                        else
                            counter++;
            }
    Console.Write("Count of numbers up to null is: " + upnull);
}
Console.Write("How much numbers do you want to input?: ");
int size = Convert.ToInt32(Console.ReadLine());
UpNull(size);
*/

/*
Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

void InterDot(double b1,double k1,double b2,double k2)
{
    double x;
    double y;
    x = k1 - k2;
    y = b1 - b2;
    y = -y;
    x = y / x;
    y = k2 * x +b2;
    Console.Write($"Your coordinates are ({x},{y})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2) Console.Write("Your lines matching");
else
if(k1 == k2) Console.Write("Your lines are parallels");
else
InterDot(b1,k1,b2,k2);
*/