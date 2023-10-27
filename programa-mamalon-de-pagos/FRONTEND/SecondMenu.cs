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
            Consultas
        }


        private ContextoMenu contexto;

        public SecondMenu(ContextoMenu contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.FormClosed += SecondMenu_FormClosed; // Suscribir al evento FormClosed

            // Cambiar el texto del LabelTitulo según el contexto
            /*switch (contexto)
              switch (contexto)
              {
                  case ContextoMenu.Institucion:
                      LabelTitulo.Text = "Gestión de Instituciones";
                      break;
                  case ContextoMenu.Facultad:
                      LabelTitulo.Text = "Gestión de Facultades";
                      break;
                  case ContextoMenu.Estudiantes:
                      LabelTitulo.Text = "Gestión de Estudiantes";
                      break;
                  case ContextoMenu.Docentes:
                      LabelTitulo.Text = "Gestión de Docentes";
                      break;
                  case ContextoMenu.Cursos:
                      LabelTitulo.Text = "Gestión de Cursos";
                      break;
                  case ContextoMenu.Secciones:
                      LabelTitulo.Text = "Gestión de Secciones";
                      break;
                  case ContextoMenu.RealizarPagos:
                      LabelTitulo.Text = "Gestión de Pagos";
                      break;
                  case ContextoMenu.Periodo:
                      LabelTitulo.Text = "Gestión de Períodos";
                      break;
                  case ContextoMenu.Reportes:
                      LabelTitulo.Text = "Gestión de Reportes";
                      break;
                  case ContextoMenu.Consultas:
                      LabelTitulo.Text = "Gestión de Consultas";
                      break;
                  default:
                      LabelTitulo.Text = "Título por defecto";
                      break;
              }
          /**/
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
                    //AbrirFormulario(new FormularioFacultad());
                    break;
                case ContextoMenu.Estudiantes:
                    AbrirFormulario(new crearestudiante());
                    break;
                case ContextoMenu.Docentes:
                    //AbrirFormulario(new FormularioDocentes());
                    break;
                case ContextoMenu.Cursos:
                    AbrirFormulario(new crearcurso());
                    break;
                    // Agrega más casos para otros contextos si es necesario
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            // Botón "Modificar": Redirigir a otro formulario según el contexto
            switch (contexto)
            {
                case ContextoMenu.Cursos:
                    AbrirFormulario(new actualizarcurso());
                    break;
                case ContextoMenu.Secciones:
                    //AbrirFormulario(new FormularioSecciones());
                    break;
                case ContextoMenu.RealizarPagos:
                    //AbrirFormulario(new FormularioRealizarPagos());
                    //break;
                case ContextoMenu.Periodo:
                    //AbrirFormulario(new FormularioPeriodo());
                    break;
                    // Agrega más casos para otros contextos si es necesario
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            // Botón "Eliminar": Agrega lógica para eliminar según el contexto si es necesario
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            // Botón "Regresar": Cierra el formulario actual y regresa al formulario anterior (menú principal)
            this.Close();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            // Botón "Salir": Cierra la aplicación completamente
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
