// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();
WriteArray(GetSpiral(9, 1));

/////////////////////////////////////////////////////

int[,] GetSpiral(int n, int num)
{
  int[,] arr = new int[n, n];

  for (int delta = 0; delta < n - 2; delta++)
  {
    for (int i = 0 + delta; i < n - delta; i++)
    {
      arr[0 + delta, i] = num;
      num++;
    }
    num--;
    for (int i = 0 + delta; i < n - delta; i++)
    {
      arr[i, n - 1 - delta] = num;
      num++;
    }
    num--;
    for (int i = n - 1 - delta; i >= 0 + delta; i--)
    {
      arr[n - 1 - delta, i] = num;
      num++;
    }
    num--;
    for (int i = n - 1 - delta; i >= 1 + delta; i--)
    {
      arr[i, 0 + delta] = num;
      num++;
    }
  }
  return arr;
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] / 10 <= 0)
        Console.Write($" {array[i, j]} ");
      else
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}