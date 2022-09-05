/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int [] createRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int [size];
    for(int i=0; i<size; i++)
        Array[i] = new Random().Next(minValue, maxValue+1); // от 100 до 999
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
int findEVENnumber(int[] Arr)
{
    int sum=0;
    for (int i=0; i<Arr.Length; i++)
        if(Arr[i] % 2 == 0) sum++;
    return sum;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: "); // 100
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: "); // 999
int max = Convert.ToInt32(Console.ReadLine());
int [] array= createRandomArray(size, min, max);
printArr(array);
Console.WriteLine($"{findEVENnumber(array)}");
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] createRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int [size];
    for(int i=0; i<size; i++)
        Array[i] = new Random().Next(minValue, maxValue+1);
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
int findnotEVENsum(int[] Arr)
{
    int sum=0;
    for (int i=0; i<Arr.Length; i++)
        if(i % 2 != 0) sum+=Arr[i];
    return sum;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] array= createRandomArray(size, min, max);
printArr(array);
Console.WriteLine($"{findnotEVENsum(array)}");
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] createRandomArray(int size, int minValue, int maxValue)
{
    double[] Array = new double [size];
    for(int i=0; i<size; i++)
        Array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return Array;
}
void printArr(double [] Arr)
{
    if (Arr.Length>0) Console.Write("[");
    for(int i = 0; i < Arr.Length; i++)
        if (i < Arr.Length-1) Console.Write(Arr[i] + " , ");
        else Console.Write(Arr[i] + "]");
    Console.WriteLine();
}
// Способ 1
void MAXminDIFF(double[] Arr)
{   Console.WriteLine($"{Arr.Max() - Arr.Min()}");  }
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
double [] array= createRandomArray(size, min, max);
printArr(array);
MAXminDIFF(array);
/*
// Способ 2
double MAXminDIFF(double[] Arr)
{
    double max = Arr[0]; double min = Arr[0];
    for (int i = 0; i<Arr.Length; i++)
        if (Arr[i]>max) max = Arr[i];
        else if (Arr[i]<min) min = Arr[i];
    return max-min;
}
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
double [] array= createRandomArray(size, min, max);
printArr(array);
Console.WriteLine($"{MAXminDIFF(array)}");
*/