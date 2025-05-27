using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Net.WebRequestMethods;
using System.Text.Json;
namespace Administracion_WinForms

{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();

        }

        private MySqlConnection conn;
        private void CargarBD()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            conn = new MySqlConnection(connectionString);
        }

        private void BorrarDatos()
        {
            textNombre.Clear();
            textPrecio.Clear();
            textStock.Clear();
        }

        private void CargarDatos()
        {
            CargarBD();
            {
                try
                {
                    conn.Open();
                    string query = "select idArticulos AS codigo, nombre AS Articulo, precio AS Valor, stock AS Stock from articulos";

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

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string precio = textPrecio.Text;
            string stock = textStock.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Completá los campos.");
                return;
            }

            CargarBD();

            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO articulos (nombre,precio,stock) VALUES (@nombre,@precio,@stock)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        BorrarDatos();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el articulo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            ArtBox.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Verifico si hay una fila seleccionada
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Consigo la id del articulo seleccionado
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["codigo"].Value);

                    var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar el articulo?",
                                                         "Confirmar",
                                                         MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                // Abro la conexion y elimino el articulo segun la id seleccionada
                                conn.Open();
                                string query = "DELETE FROM articulos WHERE idArticulos = @id";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@id", id);
                                int resultado = cmd.ExecuteNonQuery();

                                if (resultado > 0)
                                {
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el articulo.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccioná una fila para eliminar.");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void EditarLosDatos()
        {
            button1.Visible = false;
            buttonEditar.Visible = true;
            if (ArtBox.Visible)
            {
                ArtBox.Visible = false;
            }
            else
            {
                ArtBox.Visible = true;
            }

            {
                // Verifico si hay una fila seleccionada y cargo los datos.
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                textNombre.Text = fila.Cells["Articulo"].Value?.ToString();
                textPrecio.Text = fila.Cells["Valor"].Value?.ToString();
                textStock.Text = fila.Cells["Stock"].Value?.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditarLosDatos();
        }

        private void buttonAgregarART_Click(object sender, EventArgs e)
        {
            if (ArtBox.Visible)
            {
                ArtBox.Visible = false;
            }
            else
            {
                BorrarDatos();
                ArtBox.Visible = true;
            }

        }
        private void ButtonCancelar_Click_1(object sender, EventArgs e)
        {
            ArtBox.Visible = false;
            BorrarDatos();
            buttonEditar.Visible = false;
            button1.Visible = true;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Consigo la id del articulo seleccionado
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["codigo"].Value);
            CargarBD();

            {
                // Abro la conexion y actualizo los datos
                conn.Open();
                string query = "UPDATE articulos SET nombre = @nombre, precio = @precio, stock = @stock WHERE idArticulos = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", textNombre.Text);
                cmd.Parameters.AddWithValue("@precio", string.IsNullOrWhiteSpace(textPrecio.Text) ? (object)DBNull.Value : Convert.ToDecimal(textPrecio.Text));
                cmd.Parameters.AddWithValue("@stock", string.IsNullOrWhiteSpace(textStock.Text) ? (object)DBNull.Value : Convert.ToInt32(textStock.Text));

                int resultado = cmd.ExecuteNonQuery();

                // Si se actualizó el articulo, lo muestro en el datagridview
                if (resultado > 0)
                {
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se actualizó ningún articulo.");
                }
                button1.Visible = true;
                buttonEditar.Visible = false;
                ArtBox.Visible = false;
            }
        }

        private void GridDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarLosDatos();
        }

        public class CatImage
        {
            public string url { get; set; }
        }

        private async void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // Abro la ventana de login
            Form_Login UsarVentana = new Form_Login();
            UsarVentana.ShowDialog();
            LabelUsuario.Text = Sesion.NombreUsuario;

            if (Sesion.NombreUsuario == "miau")
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string url = "https://api.thecatapi.com/v1/images/search";
                        string json = await client.GetStringAsync(url);

                        var cats = JsonSerializer.Deserialize<CatImage[]>(json);
                        Perfil_Box.Load(cats[0].url);
                        Perfil_Box.SizeMode = PictureBoxSizeMode.Zoom;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conseguir la imagen de perfil: " + ex.Message);
                    }
                }
            }
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abro la ventana de parametros
            Form_Parametros UsarVentana = new Form_Parametros();
            UsarVentana.ShowDialog();
        }


        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Abro la ventana de usuario
            Form_Usuario UserVentana = new Form_Usuario();
            UserVentana.ShowDialog();

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abro la ventana de lista de usuarios
            Form_ListaUsuarios UsarVentana = new Form_ListaUsuarios();
            UsarVentana.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Venta UserVentana = new Form_Venta();
            UserVentana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Cerrar sesión y limpiar los datos de sesión
            Sesion.NombreUsuario = string.Empty;
            Sesion.IdUsuario = 0;
            LabelUsuario.Text = Sesion.NombreUsuario;
            Perfil_Box.Image = null;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                CargarBD();
                {
                    try
                    {
                        conn.Open();

                        // Obtengo el texto de la búsqueda y lo uso para filtrar los artículos
                        string busqueda = BuscarBox.Text;

                        string query = "SELECT idArticulos AS codigo, nombre AS Articulo, precio AS Valor, stock AS Stock " +
                        "FROM articulos WHERE nombre LIKE LOWER(@busqueda)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@busqueda", busqueda + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
        }
    }
}
