public static class ClassificadorDeMao
{
    public static string ClassificarMao(List<Carta> mao)
    {
        var valores = mao.Select(c => c.Valor).ToList();
        var naipes = mao.Select(c => c.Naipe).ToList();

        bool isFlush = naipes.Distinct().Count() == 1;
        bool isStraight = valores.Distinct().Count() == 5 && valores.Max() - valores.Min() == 4;
        bool isRoyal = valores.OrderBy(v => v).SequenceEqual(new List<int> { 10, 11, 12, 13, 14 });

        var grupos = valores.GroupBy(v => v).ToList();
        bool isFourOfAKind = grupos.Any(g => g.Count() == 4);
        bool isFullHouse = grupos.Count == 2 && grupos.Any(g => g.Count() == 3);
        bool isThreeOfAKind = grupos.Any(g => g.Count() == 3);
        bool isTwoPair = grupos.Count(g => g.Count() == 2) == 2;
        bool isOnePair = grupos.Any(g => g.Count() == 2);

        if (isFlush && isRoyal) return "Royal Flush";
        if (isFlush && isStraight) return "Straight Flush";
        if (isFourOfAKind) return "Quadra";
        if (isFullHouse) return "Full House";
        if (isFlush) return "Flush";
        if (isStraight) return "Straight";
        if (isThreeOfAKind) return "Trinca";
        if (isTwoPair) return "Dois Pares";
        if (isOnePair) return "Par";

        return "Carta mais alta";
    }
}
