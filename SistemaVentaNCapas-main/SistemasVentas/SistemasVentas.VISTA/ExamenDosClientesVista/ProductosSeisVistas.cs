﻿using SistemasVentas.BSS;
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
    public partial class ProductosSeisVistas : Form
    {
        public ProductosSeisVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductosSeisVistas_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = bss.ProductosSeisBss();




        }
    }
}
