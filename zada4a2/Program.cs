/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5) */

Console.Write("Введите число k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны ");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    Console.WriteLine($"Координаты пересечения прямых {x}, {y} ");
}

double ResultX(double a2, double a1, double b1, double b2)
{
    return (a2 - a1) / (b1 - b2);
}

Resultx(4, 2, 5, 9);
Console.WriteLine(ResultX(4, 2, 5, 9));

double ResultY(double a2, double a1, double b1, double b2)
{
    return b2 * (a2 - a1) / (b1 - b2) + a2;
}
Resultx(4, 2, 5, 9);
Console.WriteLine(ResultY(4, 2, 5, 9));