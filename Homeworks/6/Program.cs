// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int [] CreateRandomArray(int size)
// {
//     int [] newArray = new int [size];

//     for(int i=0;i < size; i++)
//     {
//         Console.WriteLine("Введите число");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void sumnum(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0) sum ++;
//     }
//     Console.Write($"чисел больше 0: {sum}");
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(a);
// ShowArray(myArray);
// sumnum(myArray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double check(int b1, int k1, int b2, int k2)
{
    double n = 0;
    double y1 = 0;
    double y2 = 0;
    for (double i = 100; i > -100; i = i - 0.5)
    {
        double x = i;
        y1 = k1 * x + b1;
        y2 = k2 * x + b2;
        if (y1 == y2)
        {
            n = i;
            Console.WriteLine($"Точка пересечения: {n} {y1}");
        }
    }
    return n;
}
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());
check(b1,k1,b2,k2);