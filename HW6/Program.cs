// Задача 41
// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 -> 2

// int CreateConsoleArray (int M)
// {
//     int[] array = new int[M];
//     int count = 0;
//     for (int i = 0; i < M; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// Console.Write("Введите количество элементов числового ряда: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите {num} чисeл через enter: ");
// Console.WriteLine($"Среди данных чисел {CreateConsoleArray(num)} являются положительными");
















// Задача 43
// Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1*x + b1, y = k2*x + b2;
// значения b1, k1, b2, k2 задаются пользователю
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void PointOfIntersection (float k1, float b1, float k2, float b2)
{
    float x, y;
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y =  k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения двух прямых - ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}

Console.Write("Введите k1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b1: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
int d = Convert.ToInt32(Console.ReadLine());

PointOfIntersection(a, b, c, d);