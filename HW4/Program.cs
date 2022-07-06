// Задача 25
/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int DegreeNumber (int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Введите основание степени: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int exp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DegreeNumber(num, exp));