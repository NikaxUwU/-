
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Задача 2

// int[,] Create2DRandomArray (int min, int max, int rows, int columns)
// {
//     int[,] newArray = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Find (int[,] array, int findrows, int findcolumns, int rows, int columns)
// {
//     if (findrows <= rows && findcolumns <= columns)
//     {
//         int n = array[findrows,findcolumns];
//         Console.WriteLine($"Элемент: {n}");
//     }
//     else 
//     {
//         Console.WriteLine("такого числа в массиве нет");
//     }
// }

// Console.WriteLine("Введите строку элемента");
// int findrows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец элемента");
// int findcolumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(min, max, rows, columns));
// Find(Create2DRandomArray(min, max, rows, columns), findrows, findcolumns, rows, columns);

// Задача 1

// double[,] Create2DRandomArray (int min, int max, int rows, int columns)
// {
//     double[,] newArray = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Random random = new Random();
//             newArray[i,j] = random.NextDouble();
        
//         }
//     }
//     return newArray;
// }

// void Show2DArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(min, max, rows, columns));

// Задача 3

int[,] Create2DRandomArray (int min, int max, int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min,max+1);
        }
    }
    return newArray;
}

void Show2DArray (int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
       {
            Console.Write(newArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Af (int[,] newArray, int rows, int columns)
{
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
       {
            sum = sum + newArray[i,j];
        }
        Console.Write("Среднее арифметическое: ");
        Console.Write((double) sum/rows);
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

Show2DArray(Create2DRandomArray(min, max, rows, columns));
Af(Create2DRandomArray(min, max, rows, columns),rows, columns);