using ControleGastos.Entities;

namespace ControleGastos
{
    public class GerenciadorGastosTests
    {
        [Fact]
        public void TotalGastos_DeveRetornarCem_QuandoUmGastoDeCemAdicionado()
        {
            Gasto gasto1 = new Gasto("Mc Donalds", 100);
            GerenciadorGastos g1 = new GerenciadorGastos(gasto1);

            double total = g1.TotalGastos();

            Assert.Equal(100, total);

        }

        [Fact]

        public void Retornandovalor_QuandoNenhumValoreAdicionado()
        {
            GerenciadorGastos gerenciad = new GerenciadorGastos();

            double total = gerenciad.TotalGastos();

            Assert.Equal(0, total);
        }
        [Fact]

        public void RetornarErro_QuandoValorInseridoeInvalido()
        {
            Assert.Throws<ArgumentException>(()=> new Gasto("Coca", -80));
        }
    }
}
