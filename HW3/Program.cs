// Задача 19

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n1 = num / 10000;
int n2 = num / 1000 % 10;
int n3 = num / 100 % 10;
int n4 = num / 10 % 10;
int n5 = num % 10;

int newNum = n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1;

if (newNum == num) Console.WriteLine($"{num} -> палиндром");
else Console.WriteLine($"{num} -> не палиндром");