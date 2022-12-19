/* 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);

int count = EvenNumbers(myArray);
Console.Write("Count of even numbers is: " + count);
*/

/* 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int SumNotEven(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int sum = SumNotEven(myArray);
Console.Write("Summ of numbers on not even positions is: " + sum);
*/

/* 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        array[i] = Math.Round(array[i],2);
    }
    return array;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

void DiffMinMax(double[] array)
{
    double diff;
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
        if(min > array[i])
        {
            min = array[i];
        }
    }
    diff = max - min;
    Console.WriteLine("Difference from max and min is: " + diff);
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomDoubleArray(size, min, max);
ShowArray(myArray);

DiffMinMax(myArray);
*/