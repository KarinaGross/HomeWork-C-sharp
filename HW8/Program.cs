// Задача 54
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// int[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// int[,] ArrayOrdered (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int min = array[i, j];
//             if (array[i, j + 1] < min) 
//             {
//                 int temporary = min;
//                 min = array[i, j + 1];
//                 array[i, j + 1] = temporary; // не сортирует 
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = GetArray(rows, columns, 0, 10);
// PrintArray(myArray);

// Console.WriteLine();
// int[,] newArray = ArrayOrdered(myArray);
// PrintArray(newArray);





// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }


// int[] SumElementsRow (int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//     }
//     return sum;
// }

// void RowNum (int[] array)
// {
//     int min = array[0];
//     int numRow = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             numRow = i;
//         }
//     }
//     Console.WriteLine($"Строка под номером {numRow + 1} является строкой с наименьшей суммой элементов");
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = GetArray(rows, columns, 0, 10);
// PrintArray(myArray);

// RowNum(SumElementsRow(myArray));






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// int[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MatrixProduct (int[,] array1, int[,] array2)
// {
//     int[,] product = new int[array1.GetLength(0), array1.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             product[i, j] = array1[i,j] * array2[i, j];
//         }
//     }
//     return product;
// }

// Console.Write("Введите количество строк матриц: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов матриц: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = GetArray(rows, columns, 0, 10);
// int[,] matrix2 = GetArray(rows, columns, 0, 10);
// PrintArray(matrix1);

// Console.WriteLine();
// PrintArray(matrix2);

// Console.WriteLine();
// Console.WriteLine("Произведение матриц: ");
// PrintArray(MatrixProduct(matrix1, matrix2));










// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


// задача решена, но вывод в консоле с примером не сходится. Проверить!


// int[,,] GetArray (int m, int n, int p)
// {
//     int[,,] result = new int[m, n, p];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < p; k++)
//             {
//                 result[i, j, k] = new Random().Next(10, 100); // посмотреть как можно создать массив неповторяющихся чисел
//             }
            
//         }
//     }
//     return result;
// }

// void PrintArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//             {
//                 Console.Write($"{inArray[i, j, k]}({i}, {j}, {k})\t");
//             } 
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите значение первого измерения трехмерного массива: "); //подкорректировать команду
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение второго измерения трехмерного массива: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение третьего измерения трехмерного массива: ");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = GetArray(x, y, z);
// PrintArray(myArray);










// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7