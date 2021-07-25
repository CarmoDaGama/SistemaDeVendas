using System;
using Sistema.Framework;
using DevExpress.XtraBars.Ribbon;
using Sistema.Vendas.Desktop.Views.Forms.Gerais;

namespace Sistema.Vendas.Desktop.Views.Forms.Sales
{
    public partial class FormEditorDocumentos : RibbonForm
    {
        public decimal percentagemTamanhoPanelArtigoMover { get; set; } = 100;
        public FormEditorDocumentos()
        {
            InitializeComponent();
        }
        private void MudarPercentagemTamanhoPanelArtigoMover()
        {
            if (percentagemTamanhoPanelArtigoMover == 100)
            {
                percentagemTamanhoPanelArtigoMover = 45;
            }
            else
            {
                percentagemTamanhoPanelArtigoMover = 100;
            }
        }
        private void RenderizarPanelMoveArtigo()
        {
            var tamanhoLivrePai = Width - accordionControlMenu.Width;
            var tamanhoPanelArtigoMover = tamanhoLivrePai * (percentagemTamanhoPanelArtigoMover / 100);
            panelArtigosMover.Size = new System.Drawing.Size((int)tamanhoPanelArtigoMover-15, panelArtigosMover.Height);
        }
        private void buttonDocumento_Click(object sender, EventArgs e)
        {
            GenericTasks.MudarPageFrame(sender, navigationFrameEditor, "button");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            GenericTasks.MudarPageFrame(sender, frameArtigosInvetario, "button");
        }

        private void buttonDiscontoGlobal_Click(object sender, EventArgs e)
        {
            var resultado = new FormValores().GetValor(0.0m, "DESCONTO GLOBAL");
            if (resultado.Tipo == Domain.Enuns_Entities.TipoResultado.Valido)
            {
                GenericTasks.Mensagem("Test: "
                + resultado.Dado);
            }
        }

        private void buttonArtigos_Click(object sender, EventArgs e)
        {
            MudarPercentagemTamanhoPanelArtigoMover();
            RenderizarPanelMoveArtigo();
        }

        private void accordionControlMenu_ClientSizeChanged(object sender, EventArgs e)
        {
            RenderizarPanelMoveArtigo();
        }
    }
}