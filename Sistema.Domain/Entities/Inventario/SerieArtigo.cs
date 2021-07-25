using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Domain.Entities.Inventario
{
    public  class SerieArtigo
    {
        public int SerieArtigoId { get; set; }
        public int ArtigoInventarioId { get; set; }
        public ArtigoInventario ArtigoInventario { get; set; }
        public string Serie { get; set; }
        public DateTime DataCadatro { get; set; }
    }
}
