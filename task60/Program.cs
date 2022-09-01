// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] userArray = GetMultArray(2, 2, 2);
PrintArray(userArray);


int[,,] GetMultArray(int row, int col, int width)
{
  int[,,] result = new int[row, col, width];
  int[] newNumber = new(row * col * width);
  int size = 0;
  for (int i = 0; i < row; ++i)
    for (int j = 0; j < col; ++j)
      for (int k = 0; k < width; ++k)
      {
        while (true)
        {
          result[i, j, k] = new Random().Next(10, 99 + 1);
          newNumber[size] = result[i, j, k];
        }
        size++;
      }
  return result;
};

void PrintArray(int[,,] arr)
{
  Console.WriteLine();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]}  ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
};

int random = GenerateNumber()
{

}

