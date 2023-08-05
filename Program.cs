// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double numA = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
double numB = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат возведения числа {numA} в степень {numB} будет {(long)Math.Pow(numA, numB):N0} ");
