using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Domain.Entities.Inventario
{
    public class ArtigoInventario
    {
        public int ArtigoInventarioId { get; set; }
        public int ArmazemId { get; set; }
        public Armazem Armazem { get; set; }
        public int ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
        public decimal QtdMin { get; set; }
        public decimal QtdMax { get; set; }
        public decimal Qtd { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
