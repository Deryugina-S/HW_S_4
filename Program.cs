// Задача 1. (25) Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число, которое возводим в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}

Console.Write("A в степени B равно: " + result);
