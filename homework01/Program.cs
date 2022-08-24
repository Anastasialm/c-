/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
    int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
    int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
    Console.WriteLine($"{a} больше {b}");
else    
    Console.WriteLine($"{b} больше {a}");
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число");
    int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
    int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
    int k=Convert.ToInt32(Console.ReadLine());
if (a>b)
    if (a>k)
        Console.WriteLine($"{a} - максимальное число");
    else    
        Console.WriteLine($"{k} - максимальное число");
else    
    if (b>k)
        Console.WriteLine($"{b} - максимальное число");
    else    
        Console.WriteLine($"{k} - максимальное число");
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
    int a=Convert.ToInt32(Console.ReadLine());
if (a%2==0)
    Console.WriteLine($"Число {a} - чётное");
else    
    Console.WriteLine($"Число {a} - НЕ чётное");  
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
    int N=Convert.ToInt32(Console.ReadLine());
    int a=1;
if (N<1)
    Console.WriteLine("Чётных чисел, подходящих условию задачи, не существует");
else
    while (a<(N+1))
    {
        if (a%2==0)
            if (a<(N-1))
                Console.Write(a + ", ");
            else
                Console.Write(a);
        a++;
    }
*/
