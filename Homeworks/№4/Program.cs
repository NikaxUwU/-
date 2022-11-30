// Задача 1

// int NewFn(int num, int x, int res)
// {
//     for (int i = 1; i < x; i++)
//     {
//         res = res * num;
//     }
//     return res;
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// int x = Convert.ToInt32(Console.ReadLine());
// int res = num;
// Console.WriteLine(NewFn(num, x, res));

// Задача 2

// int FindSum(int sum, int num)
// {
//     while(num > 0)
//     {
//         sum = sum + num % 10;
//         num = num/10;
//     }
//     return sum;
// }
// int sum = 0;
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(sum, num));

// Задача 3

int[] Array (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 100 + 1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
int size = 8;
int[] myArray = Array(size);
ShowArray(myArray);