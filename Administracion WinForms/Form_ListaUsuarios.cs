using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Administracion_WinForms
{
    public partial class Form_ListaUsuarios : Form
    {
        public Form_ListaUsuarios()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private void CargarBD()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            conn = new MySqlConnection(connectionString);
        }

        private void CargarDatos()
        {
            CargarBD();
            {
                // Cargar los datos de usuarios y los muestro en el DataGridView
                try
                {
                    conn.Open();
                    string query = "select idUsuarios AS Codigo, usuario AS Nombre from usuarios";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void Form_ListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarBD();
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sesion.NombreUsuario == "admin")
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Codigo"].Value) != Sesion.IdUsuario)
                {
                    // Verifico si hay una fila seleccionada
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        // Consigo la id del articulo seleccionado                       
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Codigo"].Value);

                        var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar este usuario?",
                                                             "Confirmar",
                                                             MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            CargarBD();

                            try
                            {

                                // Abro la conexion y elimino el articulo segun la id seleccionada
                                conn.Open();
                                string query = "DELETE FROM usuarios WHERE idUsuarios = @id";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@id", id);
                                int resultado = cmd.ExecuteNonQuery();

                                if (resultado > 0)
                                {
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el usuario.");
                                }
                            }


                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        else
                            MessageBox.Show("Seleccioná una fila para eliminar.");
                    }
                }
                else
                    MessageBox.Show("No se puede eliminar el usuario actual.");
            }
            else
                MessageBox.Show("Solo el usuario con nombre 'admin' tiene este permiso.");
        }
    }
}

    


