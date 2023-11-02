namespace TestProjetoTDD
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "02/11/2023";
            Calculadora calculadora = new Calculadora("02/11/2023");

            return calculadora;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TestSoma(int num1, int num2, int resultado)
        {
          Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(20, 5, 15)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(20, 5, 4)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3, 0)
                );
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calculadora = construirClasse();

            calculadora.Somar(1, 2);
            calculadora.Somar(2, 2);
            calculadora.Somar(3, 2);
            calculadora.Somar(4, 2);

            var lista = calculadora.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3,lista.Count);
        }
    }
}
    