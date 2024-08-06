namespace PruebaForms
{
    public partial class principal : Form
    {

        public principal()
        {
            InitializeComponent();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmClientes abmClientes = new abmClientes();

            abmClientes.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha actual: " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
