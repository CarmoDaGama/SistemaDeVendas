using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sistema.Framework;
using Sistema.Domain.ViewModels.Geral;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Vendas.Desktop.Views.Forms.Gerais
{
    public partial class FormValores : XtraForm
    {
        public FormValores()
        {
            InitializeComponent();
            Resultado = new Resultado<decimal >()
            {
                Tipo = TipoResultado.NaoValido
            };
        }
        private Resultado<decimal > Resultado { get; set; }

        public Resultado<decimal > GetValor(decimal valor, string titulo)
        {
            if (!string.IsNullOrEmpty(textEditValor.Text))
            {
                Text = titulo;
            }
            textEditValor.Text = valor.ToString("N2");
            ShowDialog();
            return Resultado;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditValor.Text))
            {
                GenericTasks.Mensagem("Insira um valor");
                return;

            }
            var valor = Convert.ToDecimal(textEditValor.Text);
            Resultado = new Resultado<decimal>()
            {
                Tipo = TipoResultado.Valido,
                Dado = valor
            };
            Close();
        }
    }
}