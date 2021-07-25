using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using Sistema.Framework;
using Sistema.Vendas.Desktop.Views.Forms.Entities;
using DevExpress.XtraBars.Ribbon;

namespace Sistema.Vendas.Desktop.Views.Forms.Inventarios
{
    public partial class FormSaveArtigo : RibbonForm
    {
        public FormSaveArtigo()
        {
            InitializeComponent();
        }

        private void accordionElementHome_Click(object sender, EventArgs e)
        {
            var namePage = (sender as AccordionControlElement).Name.Replace("accordionElement", "page");
            navigationFrameDataArtigo.SelectedPage = (NavigationPage)Controls["navigationFrameDataArtigo"].Controls[namePage];
        }

        private void buttonClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonGetCategoria_Click(object sender, EventArgs e)
        {
            new FormCategorias().ShowDialog();
        }

        private void buttonAddArmazem_Click(object sender, EventArgs e)
        {
            new FormAddArmazem().ShowDialog();
        }

        private void buttonAddFornecedor_Click(object sender, EventArgs e)
        {
            Injections.GetFormRegisted<FormEntidades>().ShowDialog();
        }

        private void buttonAddSubstituto_Click(object sender, EventArgs e)
        {
            new FormArtigos().ShowDialog();
        }

        private void buttonAddIntegrente_Click(object sender, EventArgs e)
        {
            new FormArtigos().ShowDialog();
        }
    }
}