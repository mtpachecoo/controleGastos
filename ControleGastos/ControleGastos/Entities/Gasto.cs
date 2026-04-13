using System;
using System.Collections.Generic;
using System.Text;

namespace ControleGastos.Entities
{
    public class Gasto
    {
        public string Descricao { get; set; }
        public double Valor { get; private set; }

        public Gasto() { }

        public Gasto(string descricao, double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor menor que 0.");
            Descricao = descricao;
            Valor = valor;
        }

        public void AlterarValor(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor menor que 0.");
            Valor = valor;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"{Descricao}: R${Valor:F2}";
        }
    }
}
