// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("введите день недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek < 8 && dayWeek > 0)
{
    if (dayWeek == 6 || dayWeek == 7)
    {
        Console.WriteLine("да, выходной");
    }
    else
    {
        Console.WriteLine("нет,не выходной");
    }
}
else
{
    Console.WriteLine("неверное число");
}
