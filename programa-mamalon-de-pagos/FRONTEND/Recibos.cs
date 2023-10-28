using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
            SeleccionarBusquedaCB.SelectedIndexChanged += SeleccionarBusquedaCB_SelectedIndexChanged;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        private void Recibos_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionarBusquedaCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
