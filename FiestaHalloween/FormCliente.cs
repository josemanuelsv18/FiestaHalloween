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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        string rutaImagen;
        string connectionString = "server=localhost;database=FiestaHalloween;uid=halloween_admin;pwd=halloweenAdmin3110;";
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el filtro para mostrar solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            // Mostrar el diálogo y comprobar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                rutaImagen = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                pbxDisfraz.Image = Image.FromFile(rutaImagen);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Lista para almacenar los códigos de invitación válidos
            List<string> codigosInvitacion = new List<string>();

            // Almacenar los datos proporcionados por el usuario en un objeto de participante
            Participante obj_participante = new Participante()
            {
                nombre = txtNombre.Text,
                codigo = txtCodigoInvitacion.Text,
                contrasena = txtContraseña.Text,
                disfraz = txtDisfraz.Text,
                fotoDisfraz = rutaImagen.ToString(),
            };

            // Crear conexión con el servidor
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //definir un id inexistente para instanciar el id del nuevo usuario
                int idNuevoParticipante = -1;
                try
                {
                    conn.Open();

                    // Consulta inicial para obtener todos los códigos de invitación existentes
                    MySqlCommand cmd = new MySqlCommand("SELECT codigoInvitacion FROM Participantes", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codigosInvitacion.Add(reader.GetString("codigoInvitacion"));
                        }
                    }

                    // Si el código de invitación ingresado es válido
                    if (codigosInvitacion.Contains(obj_participante.codigo))
                    {
                        Participante objNuevoParticipante = new Participante();

                        // Consulta para obtener el resto de datos del participante con el código de usuario
                        cmd = new MySqlCommand("SELECT * FROM Participantes WHERE codigoInvitacion = @codigoInvitacion", conn);
                        cmd.Parameters.AddWithValue("@codigoInvitacion", obj_participante.codigo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si se encuentra el participante
                            {
                                idNuevoParticipante = reader.GetInt32("idParticipante");
                                objNuevoParticipante.nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? null : reader.GetString("nombre");
                                objNuevoParticipante.contrasena = reader.IsDBNull(reader.GetOrdinal("contrasena")) ? null : reader.GetString("contrasena");
                                objNuevoParticipante.disfraz = reader.IsDBNull(reader.GetOrdinal("disfraz")) ? null : reader.GetString("disfraz");
                                objNuevoParticipante.fotoDisfraz = reader.IsDBNull(reader.GetOrdinal("fotoDisfraz")) ? null : reader.GetString("fotoDisfraz");
                                objNuevoParticipante.codigo = obj_participante.codigo;
                            }
                        }

                        // Si alguno de los campos es NULL, actualizar con los valores ingresados por el usuario
                        if (string.IsNullOrEmpty(objNuevoParticipante.nombre) || string.IsNullOrEmpty(objNuevoParticipante.contrasena) || string.IsNullOrEmpty(objNuevoParticipante.disfraz))
                        {
                            // Crear string de query a la base de datos
                            string updateQuery = "UPDATE Participantes SET " +
                                                 (string.IsNullOrEmpty(objNuevoParticipante.nombre) ? "nombre = @nombre, " : "") +
                                                 (string.IsNullOrEmpty(objNuevoParticipante.contrasena) ? "contrasena = @contrasena, " : "") +
                                                 (string.IsNullOrEmpty(objNuevoParticipante.disfraz) ? "disfraz = @disfraz, fotoDisfraz = @fotoDisfraz " : "") +
                                                 "WHERE codigoInvitacion = @codigoInvitacion";

                            // Reutilizar el comando para la actualización
                            cmd = new MySqlCommand(updateQuery, conn);
                            if (string.IsNullOrEmpty(objNuevoParticipante.nombre)) cmd.Parameters.AddWithValue("@nombre", obj_participante.nombre);
                            if (string.IsNullOrEmpty(objNuevoParticipante.contrasena)) cmd.Parameters.AddWithValue("@contrasena", obj_participante.contrasena);
                            if (string.IsNullOrEmpty(objNuevoParticipante.disfraz))
                            {
                                cmd.Parameters.AddWithValue("@disfraz", obj_participante.disfraz);
                                cmd.Parameters.AddWithValue("@fotoDisfraz", obj_participante.fotoDisfraz);
                            }
                            cmd.Parameters.AddWithValue("@codigoInvitacion", obj_participante.codigo);

                            // Ejecutar la actualización
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario actualizado exitosamente.");
                            FormActividad formActividad = new FormActividad(idNuevoParticipante);
                            this.Hide();
                            formActividad.Show();
                        }
                        else
                        {
                            MessageBox.Show("Este código de invitación ya ha sido usado.");
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
