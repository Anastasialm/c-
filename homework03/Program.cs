/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void metod (string n)
{
    bool flag=true;
    for (int i=0;i<(n.Length/2);i++)
        if (n[i]!=n[(n.Length-1)-i]) flag=false;
        else flag=true;
    Console.Write(flag.ToString());
}
Console.WriteLine("Введите число");
string N = Console.ReadLine()!;  
metod(N);
*/

/*
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void metod(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double side1; double side2; double side3;
    side1 = xA-xB;
    side2 = yA-yB;
    side3 = zA-zB;
    Console.WriteLine(Math.Sqrt(Math.Pow(side1,2)+Math.Pow(side2,2)+Math.Pow(side3,2)));
}
Console.WriteLine("Введите координату X точки А");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
double zB = Convert.ToDouble(Console.ReadLine());       
metod(xA,yA,zA,xB,yB,zB);
*/

/*
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void metod(int number)
{
    for (int i=1;i<(number+1);i++)
    {
        if (i!=number)
            Console.Write(Math.Pow(i,3) + ", ");
        else
            Console.Write(Math.Pow(i,3));    
    }
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());  
metod(N);
*/