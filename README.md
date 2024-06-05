# Poker C-Sharp

`A Proposta deste projeto é criar um classificador de Mãos de acordo com as regras do Poker utilizando o C-Sharp, demonstrando minhas habilidades em POO e Procedural.`

### Baralho.cs
Neste arquivo, é criado o baralho com 52 cartas, composto por 4 naipes (Espadas, Copas, Ouros, Paus) e 13 cartas para cada naipe, numeradas de 2 a 10, e com valores especiais de 11 a 14 (Valete, Dama, Rei, Ás). Destaca-se o uso de um switch para converter o número da carta em sua representação textual correspondente, semelhante ao WHEN da linguagem Kotlin, de forma que fique conciso e sofisticado.
````
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
````

### classificadorDeMao.cs

Aqui, as cartas são filtradas e contadas de acordo com as regras do poker. O resultado dessa contagem determina a classificação da mão, que pode variar entre Royal Flush, Straight Flush, Quadra, Full House, Flush, Straight, Trinca, Dois Pares, Par e Carta mais alta.

### Program.cs

Este arquivo centraliza a execução do programa. Nele, são chamados os métodos responsáveis por criar um novo baralho, sortear as 5 cartas e classificar a mão resultante. O resultado final é impresso no console.

### Testes

O projeto inclui testes unitários para garantir que as funcionalidades estão operando corretamente. Os testes abrangem as diferentes partes do código, verificando se a criação do baralho, o sorteio das cartas e a classificação da mão estão produzindo os resultados esperados.

Ao garantir uma cobertura adequada de testes, aumentamos a confiabilidade do programa e reduzimos a probabilidade de erros durante o desenvolvimento e manutenção do código.
````
[TestMethod]
public void TestRoyalFlush()
{
    var mao = new List<Carta>
    {
        new Carta(Naipe.Espadas, 10),
        new Carta(Naipe.Espadas, 11),
        new Carta(Naipe.Espadas, 12),
        new Carta(Naipe.Espadas, 13),
        new Carta(Naipe.Espadas, 14)
    };

    string resultado = ClassificadorDeMao.ClassificarMao(mao);
    Assert.AreEqual("Royal Flush", resultado);
}
````

### Especificações

Tipo de Projeto: Aplicação de Console  
Plataforma: .NET 8.0  
Framework de Testes: MSTest 3.4.0  
