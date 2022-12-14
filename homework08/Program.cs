/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
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
void desсorder(int [ , ] Arr)
{
    for(int i=0; i<Arr.GetLength(0); i++)
        for (int k=0; k<Arr.GetLength(1);k++)
            for(int j=0; j<Arr.GetLength(1)-1;j++)
                {
                    if (Arr[i,j]<Arr[i,j+1]) 
                        {
                            int max = Arr[i,j];
                            Arr[i,j] = Arr[i,j+1];
                            Arr[i,j+1] = max;
                        }
                }
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
desсorder(array);
printArr(array);
*/

/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int rowsum(int[,]Arr,int i)
{
    int rowsum = 0;
    for(int j=0; j<Arr.GetLength(1);j++)
        rowsum +=Arr[i,j];
    return rowsum;
}
void minsumrow(int[,]Arr)
{
    int row = 0;
    int sum = rowsum(Arr,0);
    for (int i=0;i<Arr.GetLength(0);i++)
        {
            int rowsum = 0;
            for(int j=0; j<Arr.GetLength(1);j++)
                rowsum +=Arr[i,j];
            if (rowsum<sum) 
                {
                    sum=rowsum;
                    row=i;
                }
        }
    Console.WriteLine($"Минимальная сумма элементов содержится в строке {row+1}");
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
int [ , ] array= createRandom2Array(rows, columns, min, max);
Console.WriteLine();
printArr(array);
minsumrow(array);
*/

/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void comparray(int[,]Arr1, int[,]Arr2)
{
    if (Arr1.GetLength(1)!=Arr2.GetLength(0)) 
        Console.WriteLine("Невозможно вычислить произведение заданных матриц");
    else 
        {
            Console.WriteLine("Произведение заданных матриц:");
                for(int i=0;i<Arr1.GetLength(0);i++)
                    {
                        for(int j=0; j<Arr1.GetLength(1);j++)
                        {
                            int com=0;
                            for(int k=0; k<Arr2.GetLength(0);k++)
                                com+=Arr1[i,k]*Arr2[k,j];
                            Console.Write(com+ "  ");
                        }
                        Console.WriteLine();
                        }
        }
    Console.WriteLine();
}
Console.Write("Введите количество строк в 1 массиве: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в 1 массиве: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в 1 массиве: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в 1 массиве: ");
int max1 = Convert.ToInt32(Console.ReadLine());
int [ , ] array1= createRandom2Array(rows1, columns1, min1, max1);
Console.WriteLine();
Console.Write("Введите количество строк во 2 массиве: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов во 2 массиве: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов во 2 массиве: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов во 2 массиве: ");
int max2 = Convert.ToInt32(Console.ReadLine());
int [ , ] array2= createRandom2Array(rows2, columns2, min2, max2);
Console.WriteLine();
Console.WriteLine("Матрица 1:");
printArr(array1);
Console.WriteLine("Матрица 2:");
printArr(array2);
comparray(array1,array2);
*/

/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void randnumbers (int [ , , ] Arr, int min, int max)
{
    int size = 0;
    int number = 0;
    size = Arr.GetLength(0) * Arr.GetLength(1) * Arr.GetLength(2);
    int [ ] CArray = new int [size];
    for(int i=0; i < CArray.Length; i++)
        {
            int check = 0;
            CArray[i] = new Random().Next(min, max+1);
            check = CArray[i];
            if (i > 0)
                for(int j=0; j<i; j++)
                    {
                        while (CArray[i]==CArray[j])
                            {
                                CArray[i] = new Random().Next(min, max+1);
                                check = CArray[i];
                                j=0;
                            }
                        check = CArray[i]; 
                    }   
        }
    for(int i=0; i<Arr.GetLength(0); i++)
        for(int j=0; j<Arr.GetLength(1); j++)
            for(int k=0; k<Arr.GetLength(2); k++)
                    {
                        Arr[i,j,k] = CArray[number];
                        number ++;
                    }
}
void printArr(int [ , , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
        for(int j = 0; j < Arr.GetLength(1); j++)
            {
                for(int k = 0; k < Arr.GetLength(2); k++)
                Console.Write($"{Arr[i , j , k]}({i},{j},{k}) ");
                Console.WriteLine();
            }
}
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int pages = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [ , , ] array= new int[rows, columns, pages];
Console.Write("Введите минимальное значение элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (max-min+1>=rows*columns*pages)
    {
        randnumbers(array,min,max);
        printArr(array);
    }
else Console.WriteLine($"Для заданных параметров в массиве будет повторяться минимум {rows*columns*pages-max+min-1} значений");
*/

/*
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
int [ , ] create2Array(int rows, int columns)
{
    int[ , ] Array = new int [ rows, columns ];
    int numbers = 0;
    int i = 0;
    int j = 0;
    int dif = 0;
    Console.Write("Введите минимальное значение элементов в массиве: ");
    int min = Convert.ToInt32(Console.ReadLine());
    dif = rows-columns;
    while (numbers<rows*columns)
    {
        Array[i,j] = min;
        if (i<= j+1 && i+j < columns-1) j++;
        else if (i< j+dif  && i+j+ dif >= rows-1) i++;
        else if (i >= j+dif && i+j > columns-1+dif ) j--;
        else i--;
        min++;
        numbers++;
    }
    return Array;
}
void printArr(int [ , ] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i++)
    {   
        for(int j=0; j<Arr.GetLength(1); j++)
            if (Arr[i,j]<10) Console.Write("0" + Arr[i , j] + "  ");
            else Console.Write(Arr[i , j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [ , ] array= create2Array(rows, columns);
Console.WriteLine();
printArr(array);
*/

