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
    public partial class submenu : Form
    {
        public submenu()
        {
            InitializeComponent();
        }

        private void submenu_Load(object sender, EventArgs e)
        {

        }

        private void AGREGARBT_Click(object sender, EventArgs e)
        {

        }

        private void ESTUDIANTEBT_Click(object sender, EventArgs e)
        {
            consultaaumno frmconsutalaumno = new consultaaumno();
            this.Hide();
            frmconsutalaumno.Show();
        }
    }
}
