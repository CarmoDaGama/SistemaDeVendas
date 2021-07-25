using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Sistema.Framework;
using Sistema.Vendas.Desktop.Views.Forms.Entities;
using DevExpress.XtraBars.Ribbon;
using Sistema.Vendas.Desktop.Views.Forms.Inventarios;
using Sistema.Vendas.Desktop.Views.Forms.Sales;

namespace Sistema.Vendas.Desktop.Views.Forms.Main
{
    public partial class FormMain : RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonEntitdade_ItemClick(object sender, ItemClickEventArgs e)
        {
            GenericTasks.ShowFormInContainer(panelContainerForForms.Controls, Injections.GetFormRegisted<FormEntidades>());
        }

        private void buttonArtigos_ItemClick(object sender, ItemClickEventArgs e)
        {
            GenericTasks.ShowFormInContainer(panelContainerForForms.Controls, new FormArtigos());
        }

        private void buttonSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumentos().ShowDialog();
        }
    }
}