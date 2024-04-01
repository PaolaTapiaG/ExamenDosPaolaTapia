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

namespace SistemasVentas.VISTA.ExamenDosClientesVista
{
    public partial class ProductoCincoVistas : Form
    {
        public ProductoCincoVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoCincoVistas_Load(object sender, EventArgs e)
        {




            dataGridView1.DataSource = bss.ProductosCincoBss();
        }   
    }
}
