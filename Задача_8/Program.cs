// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Хотите увидеть все четные числа перед Вашим числом? Введите любое число: ");
int Num_N = Convert.ToInt32(Console.ReadLine());
int res = 1;

while (res < Num_N)
{
    Console.WriteLine(res + 1);
    res = res + 2;
}


