using System.Configuration;
using MySql.Data.MySqlClient;

namespace Administracion_WinForms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
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
            string contraseñaIngresada = textBox2.Text;
            string hash = Seguridad.Hashear(contraseñaIngresada);

            CargarBD();
            conn.Open();
            string query = "SELECT * FROM usuarios WHERE usuario = @usuario";
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string contraseña = reader["contraseña"].ToString();
                    if (contraseña == hash)
                    {
                        Sesion.IdUsuario = Convert.ToInt32(reader["idUsuarios"]);
                        Sesion.NombreUsuario = usuario;

                        Form_Login form1 = new Form_Login();
                        this.Close();
                    }
                    else
                    {
                        label4.Text = "Contraseña incorrecta.";
                    }
                }
                else
                {
                    label3.Text = "Usuario no encontrado.";
                }
            }
        }
    }
}

