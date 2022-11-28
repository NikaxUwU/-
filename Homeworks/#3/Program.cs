// Задача 1

// bool Test(int N)
// {
//     int num1 = N % 10;
//     int num2 = N % 100 / 10;
//     int num4 = N / 1000 % 10;
//     int num5 = N / 10000;
//     if(num1 == num5 && num2==num4)
//     return true;
//     return false;
// }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Test(N));


// Задача 2

// double GetLens(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double len = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
//     return len;
// }
// Console.WriteLine("Введите координаты первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetLens(x1,y1,z1,x2,y2,z2));

// Задача 3

// void Sqr3 (int N)
// {
//     Console.Write($"3 ->");
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write($"  {i * i * i}");
//     }
// }

// Console.WriteLine("Введите Число");
// int N = Convert.ToInt32(Console.ReadLine());
// Sqr3(N);