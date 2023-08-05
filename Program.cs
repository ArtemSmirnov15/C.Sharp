// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// double numA = double.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int numB = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат возведения числа {numA} в степень {numB} будет {Math.Pow(numA, numB)} ");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write ("Введите число: ");
// string array = Console.ReadLine()!;
// int sum=0;
// for (int i=0; i<array.Length;i++){
//     sum += int.Parse(array[i].ToString());
// };
// Console.Write($"Сумма цифр в числе {String.Join("",array)} будет {sum}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа через запятую без пробелов: ");
string[] array = Console.ReadLine()!.Split(",").ToArray();
for (int i=0; i<array.Length;i++){
    if (i==0) Console.Write($"[{array[i]}, ");
    else if (i==array.Length-1) Console.Write($"{array[i]}]"); 
    else Console.Write($"{array[i]}, ");
};