// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите K1:"); double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B1:"); double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите K2:"); double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B2:"); double b2 = Convert.ToDouble(Console.ReadLine());

if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine ("Решений бесконечное множество - введены параметры одной и той же прямой");
    return;
}
if (k1 == k2)
{
    Console.WriteLine ("Прямые параллельны - решений не существует");
    return;
}

double outX = (b2-b1)/(k1-k2);
double outY = k1*outX + b1;

Console.WriteLine($"Решение системы уравнений: X = {outX}, Y = {outY}");
