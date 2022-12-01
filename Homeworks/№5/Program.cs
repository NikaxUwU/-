// Задача 1 

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] CreateArray (int size)
// {
//     int [] newArray = new int [size];
//     for(int i=0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 999+1);
//     }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//     Console.Write("Получившийся массив ->");
//     for(int i=0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//  }

// void FindMinMaxSum (int[] array)
// {
//     int sumPositive = 0;
//     for (int i=0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) sumPositive = sumPositive + 1;
//     }
//     Console.WriteLine($"Положительных чисел в массиве равна -> {sumPositive}");
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(a);
// ShowArray(myArray);
// FindMinMaxSum(myArray);

// Задача 2

// int[] CreateArray (int size)
// {
//     int [] newArray = new int [size];
//     for(int i=0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(-20, 20);
//     }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//     Console.Write("Получившийся массив ->");
//     for(int i=0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//  }

// void FindMinMaxSum (int[] array)
// {
//     int sumPositive = 0;
//     for (int i=1; i < array.Length; i+= 2)
//     {
//         sumPositive += array[i];
//     }
//     Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях -> {sumPositive}");
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(a);
// ShowArray(myArray);
// FindMinMaxSum(myArray);

// Задача 3

int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 99+1);
    }
   return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FindMinMaxSum (int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    int res = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива-> {res}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(a);
ShowArray(myArray);
FindMinMaxSum(myArray);