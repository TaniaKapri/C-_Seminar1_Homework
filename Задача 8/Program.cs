﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
   
    int N = 1;

    while (N <= number)
    {
    if (N%2 == 0)
       Console.Write(N + ", ");
       N++;
    }
}
else
{
    Console.WriteLine("Введите положительное число");
}

