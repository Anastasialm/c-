/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void metod(int number)
{
    Console.WriteLine((number % 100)/10);
}
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());  
metod(a);
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void metod(int number)
{
    if (number<100)
        Console.WriteLine("Третьей цифры нет");
    else
    {
        while (number>999)
        {
            number = number / 10;
        }
    Console.WriteLine(number%10);
    }
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());  
metod(a);
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void metod(int number)
{
    if (number<5)
        Console.WriteLine("нет");
    else
        Console.WriteLine("да");
}
Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine());  
metod(a);
*/