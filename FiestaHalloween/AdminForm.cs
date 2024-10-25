using MySql.Data.MySqlClient;
using System;
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
    public partial class AdminForm : Form
    {
        private string nombre, contrasena;
        private string connectionString;

        public AdminForm(string nombre, string contrasena)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.contrasena = contrasena;
            connectionString = "server=localhost;database=FiestaHalloween;uid=" + nombre + ";pwd=" + contrasena + ";";
            //Cargar y mostrar todos los invitados a la fiesta en el listbox para registrar a concurso de disfraz
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    //Lista para almacenar a todos los invitados
                    List<string> invitados = new List<string>();

                    conn.Open();
                    //Consulta para obtener a todos los invitados registrados
                    MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM Participantes WHERE nombre IS NOT NULL", conn);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Mientras se pueda leer agregar nombres a la lista de invitados
                        while (reader.Read())
                        {
                            invitados.Add(reader.GetString("nombre"));
                        }
                    }
                    conn.Close();
                    //Escribir la lista de invitados en el listbox correspondiente
                    llenarListBox(invitados, lbxInivitadosFiesta);
                }catch(Exception ex)
                {
                    MessageBox.Show("Error en la lectura de la lista de invitados: " + ex.Message);
                }
            }
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            int cantCodigos = Convert.ToInt32(txtCantidadCodigos.Text);
            List<string> codigosExistentes = new List<string>();
            List<string> codigosGenerados = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta inicial para obtener todos los códigos de invitación existentes
                    MySqlCommand cmd = new MySqlCommand("SELECT codigoInvitacion FROM Participantes", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codigosExistentes.Add(reader.GetString("codigoInvitacion"));
                        }
                    }

                    // Generar e insertar códigos
                    for (int i = 0; i < cantCodigos; i++)
                    {
                        string codigoInvitacion;

                        // Generar código y asegurarse de que sea único
                        do
                        {
                            codigoInvitacion = GenerateRandomString(12);
                        } while (codigosExistentes.Contains(codigoInvitacion) || codigosGenerados.Contains(codigoInvitacion));

                        // Preparar el comando de inserción
                        cmd = new MySqlCommand("INSERT INTO Participantes (codigoInvitacion) VALUES (@codigoInvitacion)", conn);
                        cmd.Parameters.AddWithValue("@codigoInvitacion", codigoInvitacion);

                        // Ejecutar la inserción
                        cmd.ExecuteNonQuery();

                        // Añadir el código generado a la lista de códigos existentes y generados
                        codigosExistentes.Add(codigoInvitacion);
                        codigosGenerados.Add(codigoInvitacion);
                    }

                    conn.Close();

                    // Llenar el ListBox con los códigos generados
                    llenarListBox(codigosGenerados, lsbListaCodigos);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la creación de códigos: " + ex.Message);
                }
            }
        }

        //Metodo para mostrar la lista de codigos generados
        private void llenarListBox(List<string> lista, ListBox box)
        {
            box.Items.Clear();
            foreach(string codigo in lista)
            {
                box.Items.Add(codigo);
            }
            txtCantidadCodigos.Text = String.Empty;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }


        private void btnRegistrarDisfraz_Click(object sender, EventArgs e)
        {
            //modificar la tabla participantes a true en concursoDisfraz
            
            //verificar que el usuario haya seleccionado un invitado
            if (lbxInivitadosFiesta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un participante.");
                return;
            }
            // Obtener el nombre seleccionado
            string nombreSeleccionado = lbxInivitadosFiesta.SelectedItem.ToString();
            string updateQuery = "UPDATE Participantes SET concursoDisfraz = 1 WHERE nombre = @nombre";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombreSeleccionado);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El participante ha sido registrado en el concurso de disfraces.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el participante en el concurso.");
                    }

                }catch (Exception ex)
                {
                    MessageBox.Show("Error en la actualizacion del participante: "+ex.Message);
                }
            }
        }

        // Método para generar una cadena aleatoria
        static string GenerateRandomString(int length)
        {
            // Definir el conjunto de caracteres permitidos (letras y números)
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            // Generar una cadena de longitud especificada
            for (int i = 0; i < length; i++)
            {
                // Escoger un carácter aleatorio del conjunto 'chars'
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
