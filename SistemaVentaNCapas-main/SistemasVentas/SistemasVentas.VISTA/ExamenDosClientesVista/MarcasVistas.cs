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
    public partial class MarcasVistas : Form
    {
        public MarcasVistas()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcasVistas_Load(object sender, EventArgs e)
        {

                dataGridView1.DataSource = bss.MarcasBss();
            
        }
    }
}
