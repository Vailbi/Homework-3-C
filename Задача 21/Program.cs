/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


double x1= Input("Введите x1: ");
double y1= Input("Введите y1: ");
double z1= Input("Введите z1: ");
double x2= Input("Введите x2: ");
double y2= Input("Введите y2: ");
double z2= Input("Введите z2: ");

Console.WriteLine(Math.Sqrt(square((x1-x2))+square((y1-y2))+square((z1-z2))));

double Input (string x)
{
    Console.Write(x);
    return Convert.ToInt32(Console.ReadLine());
}

double square (double a)
{
    a = a*a;
    return a;
}