// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows, columns);
PrintArray(array);

// Создание массива
double[,] GetArray(int m, int n){
    double[,] res = new double[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
            res[i,j] = new Random().NextDouble();
            }
        }
    return res;
}
// Печать массива
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
        Console.Write($"{Math.Round(array[i,j], 2)}  ");
        }   
    Console.WriteLine();
    }
}


// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: A(I,j) = i+j. Выведите полученный 
// массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количкство строк ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.WriteLine("Введите количкство строк ");
// int columns = int.Parse(Console.ReadLine())!;


// int [,] array = GetArray(rows,columns);
// PrintArray(array);

// // метод создания массива
// int[,] GetArray (int rows, int columns){
//     int[,] result = new int[rows, columns];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<columns; j++){
//             result[i,j] = i+j;
//         }

//     }
//     return result;
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


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.Write("Введите строку: ");
// int Rows_Array = int.Parse(Console.ReadLine())!;
// Console.Write("Введите столбец: ");
// int Columns_Array = int.Parse(Console.ReadLine())!;
// Array_Element(array);

// // метод создания массива
// int[,] GetArray (int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows, columns];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<columns; j++){
//             result[i,j] = new Random().Next(minValue , maxValue);
//         }

//     }
//     return result;
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
// // находжение элемента массива
// void Array_Element (int [,] array){
//     bool ind1 = false;
//     int ind2 = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i == Rows_Array & j == Columns_Array) {
//                 ind2 = array[i,j];
//                 ind1 = true;
//                             }
//         }
//     } 
//     if (ind1 != false) {
//         Console.WriteLine($"Элемент масcива i={Rows_Array}, j={Columns_Array} будет {ind2}");
//     }
//     else Console.WriteLine("Такого элемента не существует");
// }    
 
 
// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.Write("Введите строку: ");
// int Rows_Array = int.Parse(Console.ReadLine())!;
// Console.Write("Введите столбец: ");
// int Columns_Array = int.Parse(Console.ReadLine())!;
// Array_Element(array);

// // метод создания массива
// int[,] GetArray (int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows, columns];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<columns; j++){
//             result[i,j] = new Random().Next(minValue , maxValue);
//         }
//     }
//     return result;
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
// // находжение элемента массива
// void Array_Element (int [,] array){
//     int sum = 0;
//     int ind1 = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if 
//         }
//     } 
//     if (ind1 != false) {
//         Console.WriteLine($"Элемент мaссива i={Rows_Array}, j={Columns_Array} будет {ind2}");
//     }
//     else Console.WriteLine("Такого элемента не существует");
// }   

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.Write("Введите строку: ");
// int Rows_Array = int.Parse(Console.ReadLine())!;
// Console.Write("Введите столбец: ");
// int Columns_Array = int.Parse(Console.ReadLine())!;
// Array_Element(array);

// метод создания массива
// int[,] GetArray (int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows, columns];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<columns; j++){
//             result[i,j] = new Random().Next(minValue , maxValue);
//         }

//     }
//     return result;
// }
// Вывод массива
// void PrintArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i ++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();

//     }
    
// }
// // находжение элемента массива
// void Array_Element (int [,] array){
//     bool ind1 = false;
//     int ind2 = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i == Rows_Array & j == Columns_Array) {
//                 ind2 = array[i,j];
//                 ind1 = true;
//                             }
//         }
//     } 
//     if (ind1 != false) {
//         Console.WriteLine($"Элемент масcива i={Rows_Array}, j={Columns_Array} будет {ind2}");
//     }
//     else Console.WriteLine("Такого элемента не существует");
// }    
 
 
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine())!;
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine())!;
// int [,] array = GetArray(rows,columns, -2, 10);
// PrintArray(array);
// Console.WriteLine();

// Arithmetic_mean_of_array_column(array);

// // метод создания массива
// int[,] GetArray (int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows, columns];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<columns; j++){
//             result[i,j] = new Random().Next(minValue , maxValue);
//         }
//     }
//     return result;
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
// // находжение среднеарифметического столбца
// void Arithmetic_mean_of_array_column (int [,] array){
//     int Array_column_sum = 0;
//     double ind1 = 0;
//     for (int j = 0; j < array.GetLength(1); j++){
//         for (int i = 0; i < array.GetLength(0); i++){
//             if ( i < array.GetLength(0)) {
//                 Array_column_sum += array[i,j];
//                 ind1 ++;
//             }
//         }
//     Console.WriteLine($"Среднеарифметическое стобца {j+1} равно {Math.Round(Array_column_sum/ind1, 2)}");
//     Array_column_sum = 0;
//     ind1 = 0;    
//     } 
// }
    