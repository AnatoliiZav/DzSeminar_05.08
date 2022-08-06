Console.WriteLine("Введите число больше 1: ");
int N = int.Parse(Console.ReadLine());

for ( int a = 2; a <= N; a = a + 2)
{
    Console.Write($"{a} ");   
}
