using PruebaForms.Interfaz;

namespace PruebaForms
{
    public partial class principal : Form
    {

        public principal()
        {
            InitializeComponent();
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            datosClientes datosClientes = new datosClientes();
            datosClientes.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha actual: " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmProvedoores_Click(object sender, EventArgs e)
        {
            datosProveedores datosProveedores = new datosProveedores();
            datosProveedores.Show();
        }
    }
}
