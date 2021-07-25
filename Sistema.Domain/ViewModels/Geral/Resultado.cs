using Sistema.Domain.Enuns_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Domain.ViewModels.Geral
{
    public class Resultado<TipoDado> 
    {
        public TipoResultado Tipo { get; set; }
        public TipoDado Dado { get; set; }

    }
}
