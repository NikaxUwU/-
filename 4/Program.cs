int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
while (num2 <= num1)
{
    if (num2 % 2 == 0)
    {
        Console.Write(num2);
        Console.Write(" ");
    }
    num2++;
}