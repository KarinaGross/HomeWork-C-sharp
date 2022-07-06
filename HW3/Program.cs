// // Задача 19

// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int n1 = num / 10000;
// int n2 = num / 1000 % 10;
// int n3 = num / 100 % 10;
// int n4 = num / 10 % 10;
// int n5 = num % 10;

// int newNum = n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1;

// if (newNum == num) Console.WriteLine($"{num} -> палиндром");
// else Console.WriteLine($"{num} -> не палиндром");



// Задача 21

Console.Write("Введите х координату точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х координату точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

Console.Write($"A({xa}, {ya}, {za}), B({xb}, {yb}, {zb}) -> ");
double S = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
Console.WriteLine(Math.Round(S, 2));