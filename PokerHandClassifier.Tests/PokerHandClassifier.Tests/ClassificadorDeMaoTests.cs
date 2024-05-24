namespace PokerHandClassifier.Tests
{
    [TestClass]
    public class ClassificadorDeMaoTests
    {
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

        [TestMethod]
        public void TestStraightFlush()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Copas, 5),
                new Carta(Naipe.Copas, 6),
                new Carta(Naipe.Copas, 7),
                new Carta(Naipe.Copas, 8),
                new Carta(Naipe.Copas, 9)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Straight Flush", resultado);
        }

        [TestMethod]
        public void TestQuadra()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 3),
                new Carta(Naipe.Paus, 3),
                new Carta(Naipe.Copas, 3),
                new Carta(Naipe.Espadas, 3),
                new Carta(Naipe.Ouros, 10)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Quadra", resultado);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 6),
                new Carta(Naipe.Paus, 6),
                new Carta(Naipe.Copas, 6),
                new Carta(Naipe.Espadas, 9),
                new Carta(Naipe.Ouros, 9)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Full House", resultado);
        }

        [TestMethod]
        public void TestFlush()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Copas, 2),
                new Carta(Naipe.Copas, 4),
                new Carta(Naipe.Copas, 7),
                new Carta(Naipe.Copas, 9),
                new Carta(Naipe.Copas, 12)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Flush", resultado);
        }

        [TestMethod]
        public void TestStraight()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 5),
                new Carta(Naipe.Paus, 6),
                new Carta(Naipe.Copas, 7),
                new Carta(Naipe.Espadas, 8),
                new Carta(Naipe.Ouros, 9)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Straight", resultado);
        }

        [TestMethod]
        public void TestTrinca()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 2),
                new Carta(Naipe.Paus, 2),
                new Carta(Naipe.Copas, 2),
                new Carta(Naipe.Espadas, 8),
                new Carta(Naipe.Ouros, 11)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Trinca", resultado);
        }

        [TestMethod]
        public void TestDoisPares()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 4),
                new Carta(Naipe.Paus, 4),
                new Carta(Naipe.Copas, 9),
                new Carta(Naipe.Espadas, 9),
                new Carta(Naipe.Ouros, 12)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Dois Pares", resultado);
        }

        [TestMethod]
        public void TestPar()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 7),
                new Carta(Naipe.Paus, 7),
                new Carta(Naipe.Copas, 3),
                new Carta(Naipe.Espadas, 8),
                new Carta(Naipe.Ouros, 13)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Par", resultado);
        }

        [TestMethod]
        public void TestCartaMaisAlta()
        {
            var mao = new List<Carta>
            {
                new Carta(Naipe.Ouros, 2),
                new Carta(Naipe.Paus, 5),
                new Carta(Naipe.Copas, 7),
                new Carta(Naipe.Espadas, 9),
                new Carta(Naipe.Ouros, 12)
            };

            string resultado = ClassificadorDeMao.ClassificarMao(mao);
            Assert.AreEqual("Carta mais alta", resultado);
        }
    }
}
