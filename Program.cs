Console.Write("Digite a largura (1 a 10): ");
int largura = int.Parse(Console.ReadLine());

Console.Write("Digite a altura (1 a 10): ");
int altura = int.Parse(Console.ReadLine());

Console.WriteLine("\nContorno do retângulo:\n");

for (int i = 0; i < altura; i++)
{
    if (i == 0 || i == altura - 1)
    {
        // Primeira ou última linha: só asteriscos
        Console.WriteLine(new string('*', largura));
    }
    else
    {
        // Linhas do meio: * + espaços + *
        Console.Write("*");
        Console.Write(new string(' ', largura - 2));
        if (largura > 1)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
