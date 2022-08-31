// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой
//  строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] userArray = GetArrayRandom(3, 20, 0, 9);
PrintArray(userArray);
PrintArray(GetArrayRowsMaxMin(userArray));

//////////////////////////////////////////////////////////////////////

int[,] GetArrayRandom(int rows, int columns, int minItem, int maxItem)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      result[i, j] = new Random().Next(minItem, maxItem + 1);
  return result;
};

void PrintArray(int[,] inArray)
{
  Console.WriteLine();
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
};

int[,] GetArrayRowsMaxMin(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      int max = 0;
      for (int k = 0; k < inArray.GetLength(1) - 1; k++)
      {
        if (inArray[i, k] <= inArray[i, k + 1])
        {
          max = inArray[i, k + 1];
          inArray[i, k + 1] = inArray[i, k];
          inArray[i, k] = max;
        }
      }
    }
  }
  return inArray;
};