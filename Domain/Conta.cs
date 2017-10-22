using System;

namespace ContaLuz.Domain
{
    public class Conta : Entity
    {
        public DateTime DateLeitura { get; set; }

        public int NumLeitura { get; set; }

        public int KwGasto { get; set; }

        public Decimal ValorPagar { get; set; } 

        public DateTime DataPagamento { get; set; }

        public Decimal MediaConsumo { get; set; }

    }
}