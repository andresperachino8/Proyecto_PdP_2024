using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms
{
    public partial class datosClientes : Form
    {
        public datosClientes()
        {
            InitializeComponent();
        }

        private void datosClientes_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("C:\\Users\\Andrés Perachino\\Desktop\\PruebaForms\\PruebaForms\\Repositorio\\data.xml");

            // Establecer el DataSource del DataGridView
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
