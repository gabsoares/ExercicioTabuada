Console.Write("Digite o numero que vc deseja saber a tabuada: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    if (num > 0)
    {
        int mult = num * i;
        Console.WriteLine($"{num}x{i} = {mult}");
    }
}
