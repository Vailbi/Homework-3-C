﻿/*  Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */


System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
double num = 1;
double result = 0;
while (num<=N)
{
    result= num*num*num;
    num++;
    Console.Write(result+", ");
}
