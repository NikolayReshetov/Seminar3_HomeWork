﻿// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите значение X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt( Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2) );

Console.Write($"Расстояние = {d:f2}");