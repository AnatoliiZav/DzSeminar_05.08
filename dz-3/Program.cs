Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int b = a / 2;

if (b * 2 == a)
{
    Console.WriteLine($"{a} является четным");
}
else
{
    Console.WriteLine($"{a} является нечетным");
}