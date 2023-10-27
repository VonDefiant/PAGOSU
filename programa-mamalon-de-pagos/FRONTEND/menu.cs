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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Docentes);
            formularioSecondMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Facultad);
            formularioSecondMenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*crearestudiante frmcrearestudiante = new crearestudiante();
            this.Hide();
            frmcrearestudiante.Show();*/

            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Estudiantes);
            formularioSecondMenu.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void CONSULTASBT_Click_1(object sender, EventArgs e)
        {
            submenu frmconsutalaumno = new submenu();
            this.Hide();
            frmconsutalaumno.Show();
        }

        private void insititutonbtm_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Institucion);
            formularioSecondMenu.ShowDialog();
        }

        private void CURSOSBT_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Cursos);
            formularioSecondMenu.ShowDialog();
        }

        private void SECCIONESBT_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Secciones);
            formularioSecondMenu.ShowDialog();
        }

        private void PAGOSBT_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.RealizarPagos);
            formularioSecondMenu.ShowDialog();
        }

        private void PERIODOBT_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Periodo);
            formularioSecondMenu.ShowDialog();
        }

        private void REPORTESBT_Click(object sender, EventArgs e)
        {
            SecondMenu formularioSecondMenu = new SecondMenu(SecondMenu.ContextoMenu.Reportes);
            formularioSecondMenu.ShowDialog();
        }
    }
}
