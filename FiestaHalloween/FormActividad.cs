﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiestaHalloween
{
    public partial class FormActividad : Form
    {
        int idUsuario;
        public FormActividad(int id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
