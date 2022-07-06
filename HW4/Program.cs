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


int DegreeNumber (int n, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= n;
    }
    return result;
}

int LenNumber(int n) 
{
    int len = 0;
    while (n > 0)
    {
        n = n / 10;
        len++;
    }
    return len;
}

int SumFigureNumber (int number)
{
    int[] array = new int[LenNumber(number)];
    int result = 0;
    for (int i = 0; i < LenNumber(number); i++)
    {
        if (LenNumber(number) < 3)
        {
            array[i] = number / DegreeNumber(10, LenNumber(number) - 1);
            number %= 10;
        }
        else
        {
            array[i] = number / DegreeNumber(10, LenNumber(number) - 1);
            number %= 10;
        }

        result += array[i];
    }
    return result;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {SumFigureNumber(num)}");

