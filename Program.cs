// Напишите цикл который на входе принимает два числа (А и В) и возводит число А в натуральную степень В.

Console.Clear();
int Degree(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int degree = Degree(A, B);
  Console.WriteLine(A + " в " + B + " степени " + " = " + degree);