// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;

Console.Clear();

Console.WriteLine("Введите пятизначное число");

int num = Convert.ToInt32(Console.ReadLine());
string numS = num.ToString();

int a1=Convert.ToInt32(numS[0].ToString());
int a2=Convert.ToInt32(numS[1].ToString());
int a4=Convert.ToInt32(numS[3].ToString());
int a5=Convert.ToInt32(numS[4].ToString());

if (a1==a5&&a2==a4)
{
    Console.WriteLine($"{num}->палиндром");
}
else 
{
    Console.WriteLine($"{num}->Не палиндром");
}
/*char a=numS[1];

char b=numS[2];

char c=numS[4];

char d=numS[5];

if (a=c&&b=d)
{
    Console.WriteLine($"{num}->палиндром");
}
else 
{
    Console.WriteLine($"{num}->Не палиндром");
}*/