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
    public partial class datosProveedores : Form
    {
        public datosProveedores()
        {
            InitializeComponent();
        }

        private void datosProveedores_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"..\\PruebaForms\\PruebaForms\\Repositorio\\datosProveedores.xml");

            // Establecer el DataSource del DataGridView
            dgvProveedores.DataSource = dataSet.Tables[0];
        }

        
    }
}
