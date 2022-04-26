// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;
Console.Clear();

Console.Write("Введите координаты первой точки X1= ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты первой точки Y1= ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты первой точки Z1= ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки X2= ");
double x2 = Convert.ToInt64(Console.ReadLine());

Console.Write("Введите координаты второй точки Y2= ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки Z2= ");
double z2 = Convert.ToDouble(Console.ReadLine());

double L= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

Console.WriteLine($"Длинна отрезка L={L:f3}");