/*
Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в 
натуральную степень B.

double Pow(double a, double b)
{
    int counter = 0;
    double result = 1;
    if(b > 0)
    {
        while(counter < b)
        {
            result *= a;
            counter++;
        }
    }
    else
    {
        while(counter > b)
        {
            result *= a;
            counter--;
        }
        result = 1/result;
    }
    return result;
}

Console.Write("Input a: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b: ");
double numB = Convert.ToDouble(Console.ReadLine());

double result = Pow(numA, numB);

Console.WriteLine($"Your A to B pow number is: {result}");
*/

/*
Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

int Summ(int number)
{
    int ed = 0;
    int coll = 0;
    while(number > 0)
    {
        ed = number % 10;
        coll += ed;
        number /= 10;
    }
    return coll;
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Summ(num);
Console.Write($"Digit summ of your number is: {result}");
*/

/*
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
*/

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input array number {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int size = 8;
int[] myArray = CreateArray(size);
ShowArray(myArray);
*/