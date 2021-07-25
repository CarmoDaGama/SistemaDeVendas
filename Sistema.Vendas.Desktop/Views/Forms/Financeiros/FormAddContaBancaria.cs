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
using Sistema.Domain.Entities.Financeiro;
using Sistema.Framework;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Vendas.Desktop.Views.Forms.Financeiros
{
    public partial class FormAddContaBancaria : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormAddContaBancaria()
        {
            InitializeComponent();
        }
        private ContaBancaria ThisConta { get; set; }
        private TypeOperationForm Operation { get; set; } = TypeOperationForm.Create;
        
        private void buttoGetTipoContacto_Click(object sender, EventArgs e)
        {
            if (Equals(ThisConta, null))
            {
                ThisConta = new ContaBancaria();
            }
            ThisConta.Banco = Injections.GetFormRegisted<FormBancos>().GetEntity();
            ThisConta.BancoId = ThisConta.Banco.BancoId;
            textEditNameBank.Text = ThisConta.Banco.Dercricao;
        }

        public ContaBancaria GetConta()
        {
            ShowDialog();
            return ThisConta;
        }
        public ContaBancaria EditarConta(ContaBancaria conta)
        {
            ThisConta = conta;
            setFieldsControlAccount();
            ShowDialog();
            return ThisConta;
        }
        private void buttonSaveEntidade_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isValidValuesField())
            {
                setObjectAccount();
                Close();
            }
        }

        private void setObjectAccount()
        {
            instanceObjectAccountIfNull();
            ThisConta.Iban = textEditIban.Text;
            ThisConta.Natureza = textEditNatureza.Text;
            ThisConta.Numero = textEditNumero.Text;
            ThisConta.Sequencia = textEditSequencia.Text;
            ThisConta.Swift = textEditSwift.Text;
        }

        private void instanceObjectAccount()
        {
            ThisConta = new ContaBancaria();
        }
        
        private void instanceObjectAccountIfNull()
        {
            if (Equals(ThisConta, null))
                instanceObjectAccount();
        }

        private void setFieldsControlAccount()
        {
            if (!GenericTasks.IsNull(ThisConta))
            {
                textEditNameBank.Text = ThisConta.Banco.Dercricao;
                textEditIban.Text = ThisConta.Iban;
                textEditNatureza.Text = ThisConta.Natureza;
                textEditNumero.Text = ThisConta.Numero;
                textEditSequencia.Text = ThisConta.Sequencia;
                textEditSwift.Text = ThisConta.Swift;
            }else
            {
                MessageBox.Show(
                    "Nenhum dado da conta passo!", 
                    "ERRO", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Close();
            }
        }

        private bool isValidValuesField()
        {
            if (string.IsNullOrEmpty(textEditIban.Text))
            {
                messageShow("Insira o IBAN!");
                return false;
            }
            else
            if (string.IsNullOrEmpty(textEditNameBank.Text))
            {
                messageShow("Insira o Banco!");
                return false;
            }
            else
            if (string.IsNullOrEmpty(textEditNatureza.Text))
            {
                messageShow("Insira o Natureza!");
                return false;
            }
            else
            if (string.IsNullOrEmpty(textEditNumero.Text))
            {
                messageShow("Insira o Número!");
                return false;
            }
            else
            if (string.IsNullOrEmpty(textEditSequencia.Text))
            {
                messageShow("Insira a Sequência!");
                return false;
            }
            else
            if (string.IsNullOrEmpty(textEditSwift.Text))
            {
                messageShow("Insira o Swift!");
                return false;
            }
            return true;
        }

        private void messageShow(string msg)
        {
            MessageBox.Show(
                    msg,
                    "MENSAGEM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void buttoGetBanco_Click(object sender, EventArgs e)
        {
            if (Equals(ThisConta, null))
            {
                ThisConta = new ContaBancaria();
            }
            ThisConta.Banco = Injections.GetFormRegisted<FormBancos>().GetEntity();
            ThisConta.BancoId = ThisConta.Banco.BancoId;
            textEditNameBank.Text = ThisConta.Banco.Dercricao;
        }
    }
}