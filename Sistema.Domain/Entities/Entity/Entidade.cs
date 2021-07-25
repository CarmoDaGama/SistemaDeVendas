using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Entities.GeralEntity;
using Sistema.Domain.Enuns_Entities;
using System.Collections.Generic;

namespace Sistema.Domain.Entities.Entity
{
    public class Entidade 
    {
        public int EntidadeId { get; set; }
        public string Nome { get; set; }
        public byte[] Imagem { get; set; }
        public TypePerson TipoPessoa { get; set; }
        public int PaisId { get; set; }
        public Pais Nacionalidade { get; set; }
        public decimal DebitoLimite { get; set; }
        public List<Contacto> Contactos { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; }
        public List<DocumentoEntidade> Documentos { get; set; }
        public List<Localidade> Moradas { get; set; }
    }
}
