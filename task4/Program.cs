﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите число 1 - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 - ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3 - ");
int number3 = int.Parse(Console.ReadLine());
int maks;
if (number1 > number2 && number1 > number3)
{
    maks = number1;
    }
else if (number2 > number3)
{
    maks = number2;
}
else 
{
    maks = number3;
    }
    Console.WriteLine(maks + " - Это число больше");