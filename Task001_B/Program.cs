// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int a = 2;
int b = 10;
int max = a;
int min = a;
if (a > b) max = a;
if (a < b) max = b;

Console.WriteLine("max = ");
Console.WriteLine(max);
Console.WriteLine("min = ");
Console.WriteLine(min);
