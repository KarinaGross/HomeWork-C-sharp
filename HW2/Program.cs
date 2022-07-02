// Задача 10

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + " -> " + num / 10 % 10);


// Задача 13
// У меня все-таки получилось решить задачу в общем виде. Написала две функции: для вычисления длины числа и для возведения числа в степень.

// int LenNumber(int n) {
//     int len = 0;
//     while (n > 0)
//     {
//         n = n / 10;
//         len++;
//     }
//     return len;
// }

// int NumberExp (int a, int b) {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int lN = LenNumber(num);
// if (lN < 3)
// {
//     Console.WriteLine("-> Третьей цифры нет");
// }
// else 
// {
//     int expan = NumberExp(10, lN - 3);
//     Console.WriteLine("Третья цифра: " + num / expan % 10);
// }


// Задача 15

Console.Write("Введите число, соответствующее дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine(day + " -> да");
}
else
{
    Console.WriteLine(day + " -> нет");
}