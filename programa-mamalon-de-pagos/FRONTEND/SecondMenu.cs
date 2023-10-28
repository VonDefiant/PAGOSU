using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programa_mamalon_de_pagos.FRONTEND;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class SecondMenu : Form
    {
        private Form formularioAbierto = null;

        public enum ContextoMenu
        {
            Institucion,
            Facultad,
            Estudiantes,
            Docentes,
            Cursos,
            Secciones,
            RealizarPagos,
            Periodo,
            Reportes,
            Consultas,
            Carrera
        }


        private ContextoMenu contexto;

        public SecondMenu(ContextoMenu contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.FormClosed += SecondMenu_FormClosed; 
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            // Botón "Agregar": Redirigir a otro formulario según el contexto
            switch (contexto)
            {
                case ContextoMenu.Institucion:
                    AbrirFormulario(new crearinstitución());
                    break;
                case ContextoMenu.Facultad:
                    AbrirFormulario(new crearfacultad());
                    break;
                case ContextoMenu.Estudiantes:
                    AbrirFormulario(new crearestudiante());
                    break;
                case ContextoMenu.Docentes:
                    AbrirFormulario(new crearprofesor());
                    break;
                case ContextoMenu.Cursos:
                    AbrirFormulario(new crearcurso());
                    break;
                case ContextoMenu.Carrera:
                    AbrirFormulario(new crearcarrera());
                    break;
                    // Agrega más casos para otros contextos si es necesario
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            // Botón "Modificar": Redirigir a otro formulario según el contexto
            /*switch (contexto)
            {
                case ContextoMenu.Cursos:
                    AbrirFormulario(new FormularioCursos());
                    break;
                case ContextoMenu.Secciones:
                    AbrirFormulario(new FormularioSecciones());
                    break;
                case ContextoMenu.RealizarPagos:
                    AbrirFormulario(new FormularioRealizarPagos());
                    break;
                case ContextoMenu.Periodo:
                    AbrirFormulario(new FormularioPeriodo());
                    break;
                    // Agrega más casos para otros contextos si es necesario
            }/**/
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            // Botón "Eliminar": Agrega lógica para eliminar según el contexto si es necesario
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        // Métodos para abrir formularios
        private void AbrirFormulario(Form formulario)
        {
            if (formularioAbierto == null || formularioAbierto.IsDisposed)
            {
                formularioAbierto = formulario;
                formulario.FormClosed += (sender, e) => { formularioAbierto = null; };
                formulario.Show();
            }
            else
            {
                formularioAbierto.Focus();
            }
        }
        private void SecondMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formularioAbierto != null && !formularioAbierto.IsDisposed)
            {
                formularioAbierto.Close();
            }
        }

    }

}
