// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] userArray = GetArrayRandom(GetRandomElem(4, 9), GetRandomElem(4, 9), 0, 9);
PrintArray(userArray);
GetRowsMaxSumElem(userArray);

//////////////////////////////////////////////////////////////////////

int GetRandomElem(int minItem, int maxItem)
{
  int result = new Random().Next(minItem, maxItem + 1);
  return result;
}

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
  Console.WriteLine();
};

void GetRowsMaxSumElem(int[,] inArray)
{
  int minSum = 0;
  int minRow = 0;
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
      sum += inArray[i, j];
    Console.Write($"{sum}  ");
    if (i == 0)
      minSum = sum;
    if (sum < minSum)
    {
      minSum = sum;
      minRow = i;
    }
  }
  Console.Write($"  -->    Cтрокa с наименьшей суммой элементов: {minRow} строка");
};