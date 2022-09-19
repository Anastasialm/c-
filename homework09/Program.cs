/*
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNums(int n, int m)
{
    if (n>m)
        {
            if(n > m) ShowNums(n-1,m);
            Console.Write(n + " ");
        }
    else 
        {
            if(m > n) ShowNums(n,m-1);
            Console.Write(n + " ");
        }
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n,m);
*/

/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int SumNums (int n, int m)
{
    if (n>m)
        {
            if(n > m) return SumNums(n-1,m) + n;
            else return m;
        }
    else
        {
            if(m > n) return SumNums(n,m-1) + m;
            else return n;
        }
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNums(n,m));
*/

/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return Akkerman (m-1,1);
         else return Akkerman (m-1,Akkerman(m,n-1));
}
Console.Write("Введите число m для функции A(m,n): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n для функции A(m,n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m,n));
*/

