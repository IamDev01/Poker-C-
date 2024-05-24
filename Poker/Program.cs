public class Program
{
    public static void Main()
    {
        Baralho baralho = new Baralho();
        List<Carta> mao = baralho.SortearCartas(5);

        Console.WriteLine("Cartas sorteadas:");
        foreach (var carta in mao)
        {
            Console.WriteLine(carta);
        }

        Console.WriteLine();
        Console.WriteLine($"Classificação da mão: {ClassificadorDeMao.ClassificarMao(mao)}");
    }
}
