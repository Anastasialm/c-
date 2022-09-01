/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int exp(int a, int b)
{
    int res=1;
    for(int i=1;i<=b;i++)
        res=res*a;
    return res;
}
Console.WriteLine("Введите число 1");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} равна {exp(A,B)}");
*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int metod (int num)
{
   int sum=0;
    while (num>0)
    {
        sum+=(num%10);
        num=num/10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр числа {n} равна {metod(n)}");
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] createArr(int size)
{
    int[] Array = new int [size];
    for(int i=0; i<size; i++)
        {
            Console.Write($"Введите {i+1} элемент массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Array[i]=n;
        }
    Console.WriteLine();
    return Array;
}
void printArr(int [] Arr)
{
    if (Arr.Length>0) Console.Write("[");
    for(int i = 0; i < Arr.Length; i++)
        if (i < Arr.Length-1) Console.Write(Arr[i] + ", ");
        else Console.Write(Arr[i] + "]");
    Console.WriteLine();
}
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine())!;
printArr(createArr(n));
*/