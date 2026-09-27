Console.Write("Введите ваше число: ");
int a = int.Parse(Console.ReadLine());
if (a == 0)
{
    Console.WriteLine("Ваше число 0, четное");
}
else
{
if (a > 0)
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Ваше число положительно-четное");
    }
    else
    {
        Console.WriteLine("Ваше число положительно-нечетное");
    }
}
else
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Ваше число отрицательно-четное");
    }
    else
    {
        Console.WriteLine("Ваше число отрицательно-нечетное");
    }
}
}
