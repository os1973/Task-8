﻿/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int numberN = int.Parse(number);
int numberN2 = 1;
for(int i = numberN2; i <= numberN; i++)
{
    Console.WriteLine(i);
}

