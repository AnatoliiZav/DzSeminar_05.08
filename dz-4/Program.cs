Console.WriteLine("Введите число больше 1: ");
int N = int.Parse(Console.ReadLine());

int a = 2;
while (a <= N)
{
    Console.Write($"{a} ");
    a = a + 2;
}
