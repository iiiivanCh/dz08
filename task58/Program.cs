// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void programm()
{
  Console.Clear();
  int row01 = GetNumberFromUser("Введите количество строк первой матрицы: ", "Ошибка ввода");
  int col01 = GetNumberFromUser("Введите количество столбцов первой матрицы: ", "Ошибка ввода");
  int row02 = GetNumberFromUser("Введите количество строк второй матрицы: ", "Ошибка ввода");
  int col02 = GetNumberFromUser("Введите количество столбцов второй матрицы: ", "Ошибка ввода");
  if (col01 == row02)
  {
    Console.WriteLine("Первая матрица");
    int[,] userArray01 = GetArrayUser(row01, col01);
    Console.WriteLine("Вторая матрица");
    int[,] userArray02 = GetArrayUser(row02, col02);
    PrintArray(userArray01);
    PrintArray(userArray02);
    int[,] multUserArrays = GetMultArray(userArray01, userArray02);
    PrintArray(multUserArrays);
  }
  else
    Console.WriteLine("Предложенные матрицы умножать нельзя");
}
programm();

//////////////////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

int[,] GetArrayUser(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      result[i, j] = GetNumberFromUser("Введите число(ввод слева направо по строкам): ", "Ошибка ввода");
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

int[,] GetMultArray(int[,] ar1, int[,] ar2)
{
  int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];

  for (int i = 0; i < ar1.GetLength(0); i++)
    for (int j = 0; j < ar2.GetLength(0); j++)
      for (int k = 0; k < ar2.GetLength(1); k++)
        m[i, k] += ar1[i, j] * ar2[j, k];
  return m;
};