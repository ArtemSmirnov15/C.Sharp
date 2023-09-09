// // Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим
// // следующий массив:
// // 9 4 2
// // 2 2 6
// // 3 4 7

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);

// int[,] positionSmallElement = new int[1, 2];
// positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
// Console.Write($"Позиция элемента: ");
// PrintArray(positionSmallElement);
// Console.WriteLine();

// int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// DeleteLines(array, positionSmallElement, arrayWithoutLines);
// Console.WriteLine($"Получившийся массив:");
// PrintArray(arrayWithoutLines);

// // метод создания массива для задач 54 и 56
// int[,] GetArray (int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i<rows; i++){
//         for (int j = 0; j<columns; j++){
//             result[i,j] = new Random().Next(minValue , maxValue);
//         }
//     }
//     return result;
// }
// // Вывод массива для задая 54 и 56
// void PrintArray (int[,] array){
//     for (int i = 0; i<array.GetLength(0); i ++){
//         for (int j = 0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// // Минимальный элемент массива
// int[,] FindPositionSmallElement(int[,] array, int[,] position)
// {
//   int temp = array[0, 0];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] <= temp)
//       {
//         position[0, 0] = i;
//         position[0, 1] = j;
//         temp = array[i, j];
//       }
//     }
//   }
//   Console.WriteLine($"\nMинимальный элемент: {temp}");
//   return position;
// }
// // Вывод массива без минимального элемента массива
// void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
// {
//   int k = 0, l = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
//       {
//         arrayWithoutLines[k, l] = array[i, j];
//         l++;
//       }
//     }
//     l = 0;
//     if (positionSmallElement[0, 0] != i)
//     {
//       k++;
//     }
//   }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine())!;
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine())!;
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine())!;
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

// создание массива
void CreateArray(int[,,] array3D)
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
// Вывод массива
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
       for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write($"{array3D[i,j,k]}({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
  }
}