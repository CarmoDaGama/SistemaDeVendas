using Sistema.Domain.Enuns_Entities;

namespace Sistema.Domain.Entities.Documentos
{
    public class Operacao
    {
        public int OperacaoId { get; set; }
        public string Descricao { get; set; }
        public TypeMovimento MovimentoInventario { get; set; }
        public TypeMovimento MovimentoFinanceiro { get; set; }
        public TypeEntity Entidade { get; set; }
        public string OperacaoSigla { get; set; }
    }
}
