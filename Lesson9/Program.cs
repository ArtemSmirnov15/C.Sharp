// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от
//  N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число N: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Answer(number,1));

// string Answer (int start, int finish){
//     if (start == 1) return start.ToString();
//     return (start +", "+ Answer(start - 1, number));
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма = {SumMN (m,n)}");

// int SumMN(int m, int n)
// {
//     if (m == n) return n;
//     return (m + SumMN(m + 1, n));
    
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(Akkerman(m, n)); 

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}