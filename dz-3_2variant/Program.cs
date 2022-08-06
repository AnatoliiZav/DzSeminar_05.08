Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"{a} является четным");
}
else
{
    Console.WriteLine($"{a} является нечетным");
}
