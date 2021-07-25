using System;
using Sistema.Domain.Entities.Entity;
using DevExpress.XtraBars.Ribbon;
using Sistema.Framework;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormAddContact : RibbonForm
    {
        private Contacto ThisContact { get; set; }

        public FormAddContact()
        {
            InitializeComponent();
        }


        public Contacto EditarContacto(Contacto contacto)
        {
            ThisContact = contacto;
            textEditContacto.Text = ThisContact.Descricao;
            textEditTipo.Text = ThisContact.Tipo.Descricao;
            ShowDialog();
            return ThisContact;
        }
        private void buttoGetTipoContacto_Click(object sender, EventArgs e)
        {
            if (Equals(ThisContact, null))
            {
                ThisContact = new Contacto();
            }
            ThisContact.Tipo = Injections.GetFormRegisted<FormTipoContactos>().GetEntity();
            ThisContact.TipoContactoId = ThisContact.Tipo.TipoContactoId;
            textEditTipo.Text = ThisContact.Tipo.Descricao;
        }

        public Contacto GetContacto()
        {
            ShowDialog();
            return ThisContact;
        }

        private void buttonSaveEntidade_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(textEditContacto.Text))
            {
                MessageBox.Show(
                    "Insira o contacto!",
                    "ERRO",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            ThisContact.Descricao = textEditContacto.Text;
        }

        private void buttonSaveClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            buttonSaveEntidade_ItemClick(sender, e);
            Close();
        }
    }
}