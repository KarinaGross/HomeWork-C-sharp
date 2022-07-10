/*  Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// int[] CreateRandomArray (int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int AmountAnEvenNumber (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// int[] myArray = CreateRandomArray(10, 100, 999);
// ShowArray(myArray);
// Console.WriteLine($"-> {AmountAnEvenNumber(myArray)}");








/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// int[] CreateRandomArray (int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddPositionNumber (int[] array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         result += array[i];
//     }
//     return result;
// }

// int[] myArray = CreateRandomArray(10, -100, 100);
// ShowArray(myArray);
// Console.WriteLine($"-> {SumOddPositionNumber(myArray)}");







/*  Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray (int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DifMaxAndMin (double[] array)
{
    double numMin = array[0];
    double numMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < numMin) numMin = array[i];
        if (array[i] > numMax) numMax = array[i];
    }
    return numMax - numMin;
}

double[] myArray = CreateRandomArray(10, 0, 1000);
ShowArray(myArray);
Console.WriteLine($"-> {DifMaxAndMin(myArray)}");