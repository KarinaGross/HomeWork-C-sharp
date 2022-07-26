// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// int[] GetArrayNumbers (int minValue, int maxValue)
// {
//     int[] result = new int[maxValue - minValue + 1];
//     result[0] = minValue;
//     for (int i = 1; i < result.Length; i++)
//     {
//         result[i] = result[i-1] + 1;
//     }
//     return result;
// }

// void PrintArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//         {
//             Console.Write($"{inArray[i]} ");
//         }
// }

// Console.Write("Введите минимальное значение: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимально значение: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] myArray = GetArrayNumbers(M, N);
// PrintArray(myArray);






// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers (int minValue, int maxValue)
// {
//     int sum = 0;
//     for (int i = minValue; i < (maxValue + 1); i++)
//     {
//         sum += i;
//     }
//     return sum;
// }


// Console.Write("Введите минимальное значение: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимально значение: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumNumbers(M, N));







// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AkkermanFunction (int m, int n)
{
    if (m == 0) return (n + 1);
    else if ((m > 0) && (n == 0))
    {
        return AkkermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else return (n + 1);
}

Console.Write("Введите минимальное значение: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимально значение: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({M}, {N}) = {AkkermanFunction(M, N)}");