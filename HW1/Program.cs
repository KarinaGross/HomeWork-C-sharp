//          Задача 2
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b) 
//     Console.WriteLine("max = " + a);
// else if (b > a) 
//     Console.WriteLine("max = " + b);
// else
//     Console.WriteLine("Числа равны");

// //          Задача 4
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max_num = a;

// if (b > max_num) 
//     max_num = b;
// if (c > max_num) 
//     max_num = c; 

// Console.WriteLine("Максимальное число " + max_num);

//          Задача 6
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
//     Console.WriteLine("Число " + num + " четное");
// else
//     Console.WriteLine("Число " + num + " нечетное");

//          Задача 8
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
while(count <= num)
{
    if (count % 2 == 0) Console.Write(count + " ");
    count += 1;
}