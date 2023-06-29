//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (M <= N)
{
for (int i = M; i <= N; i++)
{
sum += i;
}

Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);
}
else
{
Console.WriteLine("Значение M должно быть меньше или равно значению N");
}


