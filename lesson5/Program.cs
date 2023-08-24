// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// функция создания рандомного массива
// int[] GenerateRandomArray (int min_value, int max_value, int lenght_array){
//     int[] array = new int[lenght_array];
//     for (int i=0; i<lenght_array; i++){
//         array[i] = new Random().Next(min_value, max_value + 1);
//     }
//     return array;
// }

// функция перевода массива в строку
// string ArrayToSrting (int[] array){
//     string result = "";
//     for (int i=0; i<array.Length;i++){
//         if (i==0) result += $"[{array[i]}, ";
//         else if (i==array.Length-1) result += $"{array[i]}]"; 
//         else result += $"{array[i]}, ";
//     }
//     return result;
// }

// int[] RandomArray = GenerateRandomArray(100,999,new Random().Next(2,10));
// int cnt=0;
// for (int index=0; index<RandomArray.Length; index++){
//     if (RandomArray[index]%2==1) cnt+=1;
// }
// System.Console.Write($"В {ArrayToSrting(RandomArray)} количество нечетных чисел {cnt}");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] RandomArray = GenerateRandomArray(0,99,new Random().Next(6,15));
// int sum=0;
// for (int index=0; index<RandomArray.Length; index++){
//     if (index%2==1) sum+=RandomArray[index];
// }
// System.Console.Write($"В {ArrayToSrting(RandomArray)} сумма элементов, стоящих на нечётных индексах {sum}");

// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

// int[] RandomArray = GenerateRandomArray(0,99,new Random().Next(6,15));
// int max = RandomArray[0];
// int min = RandomArray[0];
// for (int index=0; index<RandomArray.Length-1; index++){
//     //if (RandomArray[index]>max) max = RandomArray[index];
//     //if (RandomArray[index]<min) min = RandomArray[index];
//     max = Math.Max(max, RandomArray[index]);
//     min = Math.Min(min, RandomArray[index]);
// }
// System.Console.Write($"В {ArrayToSrting(RandomArray)} разницa между максимальным и минимальным элементов массива {max-min}");