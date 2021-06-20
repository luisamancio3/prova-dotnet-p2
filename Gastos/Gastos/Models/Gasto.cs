using System;
using System.Collections.Generic;
using System.Text;

namespace Gastos.Models
{
    public class Gasto
    {
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public Gasto(double preco, string descricao)
        {
            Preco = preco;
            Descricao = descricao;
        }
    }
}
