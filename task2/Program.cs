// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int third = number % 10;
    Console.WriteLine($"третье число = {third}");
}
else
{
    Console.WriteLine("третьего числа нет");
}