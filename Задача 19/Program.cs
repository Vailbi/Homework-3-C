/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
 */

Console.WriteLine("Введите число");
string number1 = Console.ReadLine();


if (number1[0]==number1[4] && number1[1]==number1[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


 

