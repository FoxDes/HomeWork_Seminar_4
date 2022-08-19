// Напишите цикл который на входе принимает два числа (А и В) и возводит число А в натуральную степень В.

// Console.Clear();
// int Degree(int A, int B)
// {
//   int result = 1;
//   for(int i=1; i <= B; i++)
//   {
//     result = result * A;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int A = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int B = Convert.ToInt32(Console.ReadLine());

//   int degree = Degree(A, B);
//   Console.WriteLine(A + " в " + B + " степени " + " = " + degree);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.Write("Введите восьмизначное число: ");
int A = Convert.ToInt32(Console.ReadLine());

int i = A;
if (i > 0)
{
    i = (i /= 1) % 10;
}

int j = A;
if (j > 0)
{
    j = (j /= 10) % 10;
}

int s = A;
if (s > 0)
{
    s = (s /= 100) % 10;
}

int x = A;
if (x > 0)
{
    x = (x /= 1000) % 10;
}

int g = A;
if (g > 0)
{
    g = (g /= 10000) % 10;
}

int d = A;
if (d > 0)
{
    d = (d /= 100000) % 10;
}

int c = A;
if (c > 0)
{
    c = (c /= 1000000) % 10;
}

int y = A;
if (y > 0)
{
    y = (y /= 10000000) % 10;
}

Console.WriteLine($"[" + y + ", " + c + ", " + d + ", " + g + ", " + x + ", " + s + ", " + j + ", " + i + "]");