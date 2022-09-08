/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int pozitivNumbers(int N)
{
    int count = 0;
    for(int i=0; i<N; i++)
        {
            Console.Write($"Введите {i+1} число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0) count++;
        }
    Console.WriteLine();
    return count;
}
Console.Write("Сколько хотите ввести чисел? : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вы ввели {pozitivNumbers(n)} чисел больше 0");
*/

/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void tochka(double a, double b, double c, double d)
{
    double x = 0;
    double y = 0;
    x = (c-a)/(b-d);
    y = b*x+a;
    Console.Write($"({x} , {y})");
}
Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());  
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write($"Точка пересечения двух прямых, заданных уравнениями y={k1}x+{b1}, y={k2}x+{b2} : "); tochka(b1, k1, b2, k2);
*/