/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void RowSorting(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
RowSorting(myArray);
Show2dArray(myArray);
*/

/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int minSumLine = 0;
int sumLine = SumLineElements(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(myArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} - your minimal element row");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
*/

/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Input a number of rows for firsrt and second matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns for first and second matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateFirstRandom2dArray()
{
    Console.Write("Input a min value for first matrix: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value for first matrix: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array1 = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array1[i,j] = new Random().Next(minValue, maxValue + 1);

    return array1;
}

int[,] CreateSecondRandom2dArray()
{
    Console.Write("Input a min value for second matrix: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value for second matrix: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array2 = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array2[i,j] = new Random().Next(minValue, maxValue + 1);

    return array2;
}

void MultiplyMatrix(int[,] CreateFirstRandom2dArray, int[,] CreateSecondRandom2dArray, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < CreateFirstRandom2dArray.GetLength(1); k++)
      {
        sum += CreateFirstRandom2dArray[i,k] * CreateSecondRandom2dArray[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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

int[,] myArray1 = CreateFirstRandom2dArray();
Show2dArray(myArray1);
int[,] myArray2 = CreateSecondRandom2dArray();
Show2dArray(myArray2);

int[,] resultMatrix = new int[rows, columns];

MultiplyMatrix(myArray1, myArray2, resultMatrix);
Console.WriteLine($"\nProduct of first and second matrix:");
Show2dArray(resultMatrix);
*/

/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void CreateRandom3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Show3dArray(int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"\nInput size of array X x Y x Z:");
Console.WriteLine("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateRandom3DArray(array3D);
Show3dArray(array3D);
*/

/*
Напишите программу, которая заполнит спирально массив 4 на 4.

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

ShowArray(sqareMatrix);
*/