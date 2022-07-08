// Задача 25
/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// int DegreeNumber (int number, int degree)
// {
//     int result = 1;
//     for (int i = 0; i < degree; i++)
//     {
//         result *= number;
//     }
//     return result;
// }

// Console.Write("Введите основание степени: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите показатель степени: ");
// int exp = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DegreeNumber(num, exp));






// Задача 27
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(num + " -> ");

// int SumOfFigure (int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number = number / 10;
//     }
//     return sum;
// }
// Console.WriteLine(SumOfFigure(num));



// Задача 29
/* 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int[8];

Console.Write("[");
for (int i = 0; i < 8; i++)
{
   array[i] = new Random().Next(1, 101);
   if (i == 7) Console.Write(array[i]);
   else Console.Write(array[i] + ", ");
}
Console.WriteLine("]");