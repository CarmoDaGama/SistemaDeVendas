using Sistema.Domain.Enuns_Entities;
using System;

namespace Sistema.Domain.Entities.Admin
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public DateTime DataConfirmacao { get; set; }
        public PeriodoDia Periodo { get; set; }
        public decimal SaldoIncial { get; set; }
        public TypeEstodoTurno Estado { get; set; }

    }
}