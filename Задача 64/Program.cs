﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите значение N: ");
int N = Convert.ToInt16(Console.ReadLine());
int M = 1;

Console.WriteLine($"Натуральные числа от {N} до {M}:");
if (M>N)

for (int i = N; i <= M; i++)
    Console.Write($"{i} ");

else
    for (int i = M; i <= N; i++)
        Console.Write($"{i} ");
