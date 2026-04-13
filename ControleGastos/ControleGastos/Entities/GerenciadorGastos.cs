using System;
using System.Collections.Generic;
using System.Text;

namespace ControleGastos.Entities
{
    public class GerenciadorGastos
    {
        public List<Gasto> Gastos = new List<Gasto>();

        public GerenciadorGastos() { }

        public GerenciadorGastos(Gasto gasto)
        {
            Gastos.Add(gasto);
        }

        public void MostrarGastos()
        {
            foreach (Gasto g in Gastos)
            {
                Console.WriteLine(g.ToString());
            }
        }

        public double TotalGastos()
        {
            return Gastos.Sum(g => g.Valor);
        }
    }
}
