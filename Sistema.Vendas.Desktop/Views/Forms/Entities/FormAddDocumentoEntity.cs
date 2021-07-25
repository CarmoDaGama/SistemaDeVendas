﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormAddDocumentoEntity : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormAddDocumentoEntity()
        {
            InitializeComponent();
        }

        private void buttoGetTipoDocument_Click(object sender, EventArgs e)
        {
            new FormTypeDocuments().ShowDialog();
        }
    }
}