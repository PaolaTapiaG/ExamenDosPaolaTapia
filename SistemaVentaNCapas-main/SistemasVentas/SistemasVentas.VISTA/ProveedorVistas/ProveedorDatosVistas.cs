using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorDatosVistas : Form
    {
        public ProveedorDatosVistas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ProveedorBss bss = new ProveedorBss();
       
           
        private void ProveedorDatosVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorDatosBss();
        }
    }
}
