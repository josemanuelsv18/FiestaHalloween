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
            this.Hide();
            cliente.Show();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=FiestaHalloween;uid=halloween_admin;pwd=halloweenAdmin3110;";
            string nombre = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT nombre, contrasena FROM Participantes WHERE nombre = @nombre", conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string query = "SELECT id FROM Participantes WHERE nombre = @nombre AND contrasena = @contrasena";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            // Agregar parámetros para evitar inyecciones SQL
                            cmd.Parameters.AddWithValue("@nombre", nombreIngresado);
                            cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                            // Ejecutar el comando y leer el resultado
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Si se encuentra un usuario, obtener su ID
                                    idUsuario = reader.GetInt32("id");
                                }
                            }

                            // Verificar si se encontró un usuario con el nombre y contraseña ingresados
                            if (idUsuario != -1)
                            {
                                // Inicio de sesión exitoso, puedes usar el ID del usuario
                                MessageBox.Show("Inicio de sesión exitoso. ID de usuario: " + idUsuario);

                                // Aquí puedes redirigir al usuario a la siguiente pantalla o guardar el ID
                                // Ejemplo:
                                FormActividad formActividad = new FormActividad(idUsuario); // Si pasas el ID a otra pantalla
                                formActividad.Show();
                                this.Hide(); // Ocultar la pantalla de inicio de sesión
                            }
                            else
                            {
                                // Si no se encontró un usuario, mostrar mensaje de error
                                MessageBox.Show("Nombre o contraseña incorrectos.");
                            }

                            conn.Close();
                        }
                    }
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
