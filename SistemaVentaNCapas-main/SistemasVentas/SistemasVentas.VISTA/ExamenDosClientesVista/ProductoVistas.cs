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
    public partial class ProductoVistas : Form
    {
        public ProductoVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoVistas_Load(object sender, EventArgs e)
        {
            
          
                dataGridView1.DataSource = bss.ProductosBss();

            
        }
    }
}
