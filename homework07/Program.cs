/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [ , ] createRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    double[ , ] Array = new double [ rows, columns ];
    for(int i=0; i<rows; i++)
        for(int j=0; j<columns; j++)
            Array[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return Array;
}
void printArr(double [ , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
    {   
        for(int j=0; j<Arr.GetLength(1); j++)
            Console.Write(Arr[i , j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
double [ , ] array= createRandom2Array(rows, columns, min, max);
printArr(array);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int [ , ] createRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[ , ] Array = new int [ rows, columns ];
    for(int i=0; i<rows; i++)
        for(int j=0; j<columns; j++)
            Array[i,j] = new Random().Next(minValue, maxValue);
    return Array;
}
void printArr(int [ , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
    {   
        for(int j=0; j<Arr.GetLength(1); j++)
            Console.Write(Arr[i , j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void number ( int [,] Arr)
{
    Console.Write($"Введите позицию элемента | строка : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите позицию элемента | столбец : ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>Arr.GetLength(0)) Console.WriteLine("Такого элемента нет");
    else if(b>Arr.GetLength(1)) Console.WriteLine("Такого элемента нет");
            else Console.WriteLine($"На позиции {a},{b} находится элемент {Arr[a,b]}");
}
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int [ , ] array= createRandom2Array(rows, columns, min, max);
Console.WriteLine();
printArr(array);
number(array);
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] create2Arr(int rows, int columns)
{
    int[,] Array = new int [rows,columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            Console.Write($"Введите элемент массива для {i+1} строки,{j+1} столбца: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Array[i,j]=n;
        }
    }
    return Array;
}
void printArr(int [ , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
    {   
        for(int j=0; j<Arr.GetLength(1); j++)
            Console.Write(Arr[i , j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void mean (int [,] Arr)
{
    for (int j=0; j<Arr.GetLength(1);j++)
        {
            double sum = 0;
            double mean = 0;
            for (int i=0; i<Arr.GetLength(0); i++)
                sum+=Arr[i,j];
            mean = Math.Round(sum /(Arr.GetLength(0)),1);
            if (j != Arr.GetLength(1)-1) Console.Write(mean + " ; ");
            else Console.Write(mean);
        }
}
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [ , ] array= create2Arr(rows, columns);
Console.WriteLine();
printArr(array);
Console.Write("Среднее арифметическое каждого столбца: "); mean(array);
*/

int [ , ] createRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[ , ] Array = new int [ rows, columns ];
    for(int i=0; i<rows; i++)
        for(int j=0; j<columns; j++)
            Array[i,j] = new Random().Next(minValue, maxValue);
    return Array;
}
void printArr(int [ , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
    {   
        for(int j=0; j<Arr.GetLength(1); j++)
            Console.Write(Arr[i , j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void number ( int [,] Arr)
{
    Console.Write($"Введите позицию элемента | строка : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите позицию элемента | столбец : ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>Arr.GetLength(0)) Console.WriteLine("Такого элемента нет");
    else if(b>Arr.GetLength(1)) Console.WriteLine("Такого элемента нет");
            else Console.WriteLine($"На позиции {a},{b} находится элемент {Arr[a,b]}");
}
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int [ , ] array= createRandom2Array(rows, columns, min, max);
Console.WriteLine();
printArr(array);
number(array);