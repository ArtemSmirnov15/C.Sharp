// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

// Создание массива
double[,] GetArray(int m, int n, double minValue, double maxValue){
    double[,] res = new double[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
            res[i,j] = new double[,].Next(minValue, maxValue + 1);
            }
        }
    return res;
}
// Печать массива
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
        Console.Write($"{array[i,j]} ");
        }   
    Console.WriteLine();
    }
}