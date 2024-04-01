using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedoresVistasC
{
    public partial class ProveedorVista : Form
    {
        public ProveedorVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button11_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Nombre = textBox1.Text;
            p.Telefono = textBox2.Text;
            p.Direccion = textBox3.Text;
            p.Estado = textBox4.Text;
            bss.InsertarProveedorBss(p);
            MessageBox.Show("Se guardó correctamente a Proveedor");
        }

        private void ProveedorVista_Load(object sender, EventArgs e)
        {

        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button9_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void button12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
