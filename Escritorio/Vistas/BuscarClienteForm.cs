﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Vistas {
    public partial class BuscarClienteForm : Form {
        public BuscarClienteForm() {
            InitializeComponent();
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e) {
            var agregarClienteForm = new AgrearClienteForm();
            agregarClienteForm.Show();
        }
    }
}
