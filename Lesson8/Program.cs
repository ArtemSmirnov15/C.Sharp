// метод создания массива для задач 54 и 56
int[,] GetArray (int rows, int columns, int minValue, int maxValue){
    int[,] result = new int[rows, columns];
    for (int i = 0; i<rows; i++){
        for (int j = 0; j<columns; j++){
            result[i,j] = new Random().Next(minValue , maxValue);
        }
    }
    return result;
}
// Вывод массива для задая 54 и 56
void PrintArray (int[,] array){
    for (int i = 0; i<array.GetLength(0); i ++){
        for (int j = 0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();
// Sorted_array(array);
// PrintArray(array);


// void Sorted_array(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }


//   Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//   которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка     

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();
// min_sum_of_array_elements(array);

// // решение
// void min_sum_of_array_elements(int[,] array){
//     int Array_sum = 0;
//     int indi = 0;
//     int ind_return = 0;
//     int Array_sum1 = 10000000;
//     for (int i = 0; i<array.GetLength(0); i ++){
//         for (int j = 0; j<array.GetLength(1); j++){
//                 Array_sum += array[i,j];
//         } 
//         Console.WriteLine(Array_sum);
//         if (Array_sum < Array_sum1){
//             Array_sum1 = Array_sum;
//             ind_return = i + 1;
//         }
//         Array_sum = 0;
//         indi ++;
//     }
//     Console.WriteLine($"строка {ind_return}");
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int massive = 1;
// int[,] array1 = new int[rows,columns];
// int[,] array2 = new int[rows,columns];
// int[,] matrixC = new int[rows,columns];
// Console.WriteLine();
// GetArray(array1);
// Console.WriteLine();
// GetArray(array2);
// Console.WriteLine();
// Console.WriteLine("Первая матрица ");
// PrintArray(array1);
// Console.WriteLine();
// Console.WriteLine("Вторая матрица ");
// PrintArray(array2);
// MultiplyMatrix(array1, array2, matrixC);
// Console.WriteLine();
// Console.WriteLine("Результат ");
// PrintArray(matrixC);


// // Ввод матрицы
// void GetArray (int [,] array){
// for (int i=0; i<rows; i++){
//     for (int j=0; j<columns; j++){
//         Console.Write($"Введите числа для массива {massive}: ");
//         array[i,j] = int.Parse(Console.ReadLine())!;
//         }
//     }
//     massive++;
// }


// // Вывод массива
// void PrintArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i ++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();

//     }
// }   


// void MultiplyMatrix(int[,] array1, int[,] array2, int[,] matrixC)
//         {
//             if (array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
//             else {
//             for (int i = 0; i < matrixC.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrixC.GetLength(1); j++)
//                 {
//                     int sum = 0;
//                     for (int k = 0; k < array1.GetLength(1); k++)
//                     {
//                         sum += array1[i,k] * array2[k,j];
//                     }
//                     matrixC[i,j] = sum;
//                 }
//             }
            
//         }
//     }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите X: ");
// int x = int.Parse(Console.ReadLine())!;
// Console.Write("Введите Y: ");
// int y = int.Parse(Console.ReadLine())!;
// Console.Write("Введите Z: ");
// int z = int.Parse(Console.ReadLine())!;
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// // создание массива
// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }
// // Вывод массива
// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//        for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write($"{array3D[i,j,k]}({i},{j},{k})  ");
//       }
//       Console.WriteLine();
//     }
//   }
// }

 
