using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms.Interfaz
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
            dataSet.ReadXml(@"..\\PruebaForms\\PruebaForms\\Repositorio\\datosClientes.xml");

            dgvClientes.DataSource = dataSet.Tables[0];
        }

        
    }
}
