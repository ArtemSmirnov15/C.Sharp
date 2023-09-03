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