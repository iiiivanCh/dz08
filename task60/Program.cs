// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] userArray = GetMultArray(2, 2, 2);
PrintArray(userArray);
PrintArrayCoordinats(userArray);


int[,,] GetMultArray(int row, int col, int wid)
{
  int[,,] result = new int[row, col, wid];
  int[] newNumber = new int[row * col * wid];
  int size = 0;
  for (int i = 0; i < row; i++)
    for (int j = 0; j < col; j++)
      for (int k = 0; k < wid; k++)
      {
        bool correct = true;
        while (correct)
        {
          result[i, j, k] = new Random().Next(10, 100);
          newNumber[size] = result[i, j, k];
          correct = false;
          for (int l = 0; l < size; l++)
          {
            if (result[i, j, k] == newNumber[l])
              correct = true;
          }
        }
        size += 1;
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

void PrintArrayCoordinats(int[,,] arr)
{
  Console.WriteLine("====================");
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]}({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
  }
  Console.WriteLine("====================");
};


