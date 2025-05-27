using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Administracion_WinForms
{
    public partial class Form_Venta : Form
    {
        public Form_Venta()
        {
            InitializeComponent();
        }

        DataTable DTItemsAgregados = new DataTable();

        private MySqlConnection conn;
        private void CargarBD()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            conn = new MySqlConnection(connectionString);
        }

        private void CargarDatos()
        {
            CargarBD();
            try
            {
                conn.Open();
                string query = "SELECT idArticulos AS Codigo, nombre AS Articulo, precio AS Valor FROM articulos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridAgregar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DTItemsAgregados.Columns.Add("Codigo", typeof(int));
            DTItemsAgregados.Columns.Add("Nombre", typeof(string));
            DTItemsAgregados.Columns.Add("Valor", typeof(decimal));

            DataGridImprimir.DataSource = DTItemsAgregados;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarBD();
            try
            {
                conn.Open();
                string busqueda = textBox1.Text;
                string query = "SELECT idArticulos AS Codigo, nombre AS Articulo, precio AS Valor, stock AS Stock FROM articulos WHERE nombre LIKE LOWER(@busqueda)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@busqueda", busqueda + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataGridAgregar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGridAgregar.CurrentRow != null)
            {
                int codigo = Convert.ToInt32(DataGridAgregar.CurrentRow.Cells["Codigo"].Value);
                string nombre = DataGridAgregar.CurrentRow.Cells["Articulo"].Value.ToString();
                decimal precio = Convert.ToDecimal(DataGridAgregar.CurrentRow.Cells["Valor"].Value);

                // Verificar que no esté repetido (opcional)
                bool yaExiste = DTItemsAgregados.AsEnumerable().Any(row => row.Field<int>("Codigo") == codigo);
                if (!yaExiste)
                {
                    DTItemsAgregados.Rows.Add(codigo, nombre, precio);
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Este artículo ya fue agregado.");
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DataGridImprimir.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["Valor"].Value?.ToString(), out decimal valor))
                {
                    total += valor;
                }
            }

            label2.Text = $"Total: {total}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataGridImprimir.CurrentRow != null)
            {
                int rowIndex = DataGridImprimir.CurrentRow.Index;
                DataGridImprimir.Rows.RemoveAt(rowIndex);
                CalcularTotal();
            }
        }
    }
}
