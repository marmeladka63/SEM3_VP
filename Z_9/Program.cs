// Вывести таблицу квадратов от 1 до n, где n>0 число с клавиатуры

using System;
Console.Clear();

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);

for ( int i=1; i<=n; i++)

{
Console.Write($" {(long)Math.Pow(i, 2)}");
}


