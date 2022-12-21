/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j],2);
        }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

/*
 Напишите программу, которая на вход принимает 
 позиции элемента в двумерном массиве, 
 и возвращает значение этого элемента 
 или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

int[,] CreateRandom2to2Massive()
{
    int rows = 2;
    int columns = 2;
    int minValue = 1;
    int maxValue = 9;

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindIndex(int[,] array)
{
    Console.Write("Input row number: ");
    int i= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column number: ");
    int j = Convert.ToInt32(Console.ReadLine());
    i=i-1;
    j=j-1;

    if(i > 1) Console.Write("There is no number in your position");
    else
    {
        if(j > 1) Console.Write("There is no number in your position");
        else
        {
            Console.Write($"Your number is: {array[i,j]}");
        }
    }
}
int[,] myArray = CreateRandom2to2Massive();
Show2dArray(myArray);
FindIndex(myArray);
*/

/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в 
каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void AveregeInColumn(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    { 
    double sum = 0;
    double count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        {  
        sum += array[i,j];
        count++;
        }
    double averege = sum / count;
    averege = Math.Round(averege,2);
    Console.Write($"{averege};");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
AveregeInColumn(myArray);
*/