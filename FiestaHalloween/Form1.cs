using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FiestaHalloween
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionAdmin_Click(object sender, EventArgs e)
        {
            string nombreAdmin = txtUsuario.Text;
            string contrasenaAdmin = txtContraseña.Text;

            if (nombreAdmin == "halloween_admin" && contrasenaAdmin == "halloweenAdmin3110")
            {
                AdminForm objAdminForm = new AdminForm(nombreAdmin, contrasenaAdmin);
                this.Hide();
                objAdminForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña de administrador incorrectos");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            this.Close();
            cliente.Show();
        }
    }
}
