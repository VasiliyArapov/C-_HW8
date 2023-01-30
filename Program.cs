// Задача 1
// int[,] array = GetArray(4, 5, 1, 9);
// PrintArray(array);
// System.Console.WriteLine();
// SelectionSortRows(array);
// PrintArray(array);

// Задача 2
// int[,] array = GetArray(4, 5, 1, 9);
// PrintArray(array);
// System.Console.WriteLine();
// PrintMinRowSum(array);

// Задача 3
// System.Console.WriteLine("Первая матрица:");
// int[,] array1 = GetArray(3, 2, 1, 4);
// int[,] array2 = GetArray(2, 3, 1, 4);
// PrintArray(array1);
// System.Console.WriteLine("Вторая матрица:");
// PrintArray(array2);
// if(array1.GetLength(0) == array2.GetLength(1))
// {
//     System.Console.WriteLine("Результат умножения:");
//     int[,] resultArray = MatrixMultiplication(array1, array2);
//     PrintArray(resultArray);
// }
// else
//     System.Console.WriteLine("Эти матрицы нельзя перемножить!!");

// ----------Methods-----------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SelectionSortRows(int[,] array)
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

void PrintMinRowSum(int[,] array)
{
    int minSum = 9999;
    int tempSum = 0;
    int indexRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i,j];
        }
        if(tempSum < minSum) 
        {
            minSum = tempSum;
            indexRow = i;
        }
        tempSum = 0;
    }
    Console.WriteLine($"Row number is {indexRow}, min summ is {minSum}");
}

int[,] MatrixMultiplication(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                result[i,j] += A[i,k] * B[k,j];
            }
        }
    }
    return result;
}