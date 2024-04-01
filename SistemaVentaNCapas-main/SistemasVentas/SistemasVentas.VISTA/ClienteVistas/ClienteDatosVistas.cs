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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteDatosVistas : Form
    {
        public ClienteDatosVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
      
        
        private void ClienteDatosVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClientesDatosBss();
        }
    }
}
