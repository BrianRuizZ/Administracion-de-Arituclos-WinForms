using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administracion_WinForms
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private MySqlConnection conn;
        private void CargarBD()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            conn = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string contraseñaHasheada = Seguridad.Hashear(contraseña);

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                ErrorNombre.Text = "Por favor, complete todos los campos.";
                ErrorContraseña.Text = "Por favor, complete todos los campos.";
                return;
            }
            else
                ErrorNombre.Text = "";
                ErrorContraseña.Text = "";

            if (textBox2.Text != textBox3.Text)
            {
                ErrorConfContraseña.Text = "Las contraseñas no coinciden.";
                return;
            }
            else
                ErrorConfContraseña.Text = "";

                CargarBD();
            conn.Open();

            try
            {
                // Verificar si el usuario ya existe
                string queryCheck = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@usuario", usuario);
                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (count > 0)
                {
                    ErrorNombre.Text = "El usuario ya existe.";
                    return;
                }
                else
                    ErrorNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario: " + ex.Message);
                return;
            }
                  
            string query = "INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @contraseñaHasheada)";

            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseñaHasheada", contraseñaHasheada);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el usuario: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
