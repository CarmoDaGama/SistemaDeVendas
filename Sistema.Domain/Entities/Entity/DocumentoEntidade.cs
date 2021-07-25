using System;

namespace Sistema.Domain.Entities.Entity
{
    public class DocumentoEntidade
    {
        public int DocumentoEntidadeId { get; set; }
        public int TipoDocumentoEntidadeId { get; set; }
        public TipoDocumentoEntidade Tipo { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataValidade { get; set; }

    }
}
