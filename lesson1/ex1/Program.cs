﻿ //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.Write("введите первое число ->");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ведите второе число ->");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(num1, num2);
System.Console.WriteLine(max);
