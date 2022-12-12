/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, 
является ли оно палиндромом. 

bool Palindrome(int num)
{
    int temp = num;
    int rev = 0;
    while(num > 0)
    {
        int dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    }
    if(temp == rev)
        return true;
    else
        return false;
}
Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(Palindrome(num)  == true)
    Console.WriteLine($"Your number is palindrome ");
if(Palindrome(num)  == false)
    Console.WriteLine($"Your number is not palindrome ");
*/

/* Напишите программу, которая принимает на вход 
координаты двух точек и находит 
расстояние между ними в 3D пространстве. 

double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.WriteLine("Input coordinates of x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double length = Length(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Your distanse from three dots is: {length}");
*/

/*
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов 
чисел от 1 до N.

void Сube(int num)
{
    int counter = 1;
    while(counter <= num)
    {
        Console.Write($"{Math.Pow(counter, 3)} ");
        counter++;
    }
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cube nubers are {num}: ");
Сube(num);
*/