public enum Naipe
{
    Espadas, // Spades
    Copas,   // Hearts
    Ouros,   // Diamonds
    Paus     // Clubs
}

public class Carta
{
    public Naipe Naipe { get; set; }
    public int Valor { get; set; } // 2-10 para valores numéricos, 11 = Valete, 12 = Dama, 13 = Rei, 14 = Ás

    public Carta(Naipe naipe, int valor)
    {
        Naipe = naipe;
        Valor = valor;
    }

    public override string ToString()
    {
        string valorStr = Valor switch
        {
            11 => "Valete",
            12 => "Dama",
            13 => "Rei",
            14 => "Ás",
            _ => Valor.ToString()
        };
        return $"{valorStr} de {Naipe}";
    }
}

public class Baralho
{
    private List<Carta> cartas;

    public Baralho()
    {
        cartas = new List<Carta>();
        foreach (Naipe naipe in Enum.GetValues(typeof(Naipe)))
        {
            for (int valor = 2; valor <= 14; valor++)
            {
                cartas.Add(new Carta(naipe, valor));
            }
        }
        Embaralhar();
    }

    public void Embaralhar()
    {
        Random rand = new Random();
        cartas = cartas.OrderBy(c => rand.Next()).ToList();
    }

    public List<Carta> SortearCartas(int quantidade)
    {
        var sorteadas = cartas.Take(quantidade).ToList();
        cartas = cartas.Skip(quantidade).ToList();
        return sorteadas;
    }
}
