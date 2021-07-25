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

namespace Sistema.Vendas.Desktop.Views.Forms.Inventarios
{
    public partial class FormAddArmazem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormAddArmazem()
        {
            InitializeComponent();
        }

        private void buttoGetArmazem_Click(object sender, EventArgs e)
        {
            new FormArmazens().ShowDialog();
        }
    }
}