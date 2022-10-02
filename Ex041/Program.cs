// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел будем вводить?");
int M = Convert.ToInt32(Console.ReadLine());
int i = 1;
int cou = 0;

while (i <= M)
{
    Console.WriteLine($"Введите {i}-е число: ");
    if (Convert.ToInt32(Console.ReadLine())> 0) cou++;
    i++;
}
Console.WriteLine($"Количество положительных чисел: {cou}");