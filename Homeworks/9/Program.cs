//Задач 2

// int Summ(int n, int m)
// {
//     if (n > m)
//     {
//         return Summ(n-1, m) + n;
//     }
//     return n;
// }

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int x = Summ(n, m);
// Console.WriteLine(x);

//Задача 1

// void num(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         num(n-1);
//     }
// }
// int n = Convert.ToInt32(Console.ReadLine());
// num(n);


// Задача 3

int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0 && n != 0)
    {
        return A(n - 1, 1);
    }
    else 
    {
        return A(n - 1, A(n, m - 1));
    } 
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int x = A(n, m);
Console.WriteLine(x);
