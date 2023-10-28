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
    public partial class menureportes : Form
    {
        public menureportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportesporjornada frmreportesporjornada = new reportesporjornada();
            this.Hide();
            frmreportesporjornada.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
