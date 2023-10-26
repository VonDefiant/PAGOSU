namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearestudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreestuadiante = new TextBox();
            pictureBox1 = new PictureBox();
            telefonoalumno = new TextBox();
            EMAILESTUDIANTE = new TextBox();
            FACULTAD = new ListBox();
            INSTITUCION = new ListBox();
            SECCIONESTUDIANTE = new TextBox();
            CARRERA = new ListBox();
            textBox3 = new TextBox();
            NACIMIENTOESTUDIANTE = new TextBox();
            SAVEBUTTON = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombreestuadiante
            // 
            nombreestuadiante.ForeColor = SystemColors.InfoText;
            nombreestuadiante.Location = new Point(154, 31);
            nombreestuadiante.Margin = new Padding(3, 2, 3, 2);
            nombreestuadiante.Name = "nombreestuadiante";
            nombreestuadiante.Size = new Size(409, 23);
            nombreestuadiante.TabIndex = 0;
            nombreestuadiante.Text = "INGRESE EL NOMBRE COMPLETO";
            nombreestuadiante.TextAlign = HorizontalAlignment.Center;
            nombreestuadiante.TextChanged += nombreestuadiante_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alumno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(21, 31);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 122);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telefonoalumno
            // 
            telefonoalumno.ForeColor = SystemColors.InfoText;
            telefonoalumno.Location = new Point(156, 108);
            telefonoalumno.Margin = new Padding(3, 2, 3, 2);
            telefonoalumno.Name = "telefonoalumno";
            telefonoalumno.Size = new Size(110, 23);
            telefonoalumno.TabIndex = 2;
            telefonoalumno.Text = "TELEFONO";
            telefonoalumno.TextAlign = HorizontalAlignment.Center;
            telefonoalumno.TextChanged += telefonoalumno_TextChanged;
            // 
            // EMAILESTUDIANTE
            // 
            EMAILESTUDIANTE.ForeColor = SystemColors.InfoText;
            EMAILESTUDIANTE.Location = new Point(154, 56);
            EMAILESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            EMAILESTUDIANTE.Name = "EMAILESTUDIANTE";
            EMAILESTUDIANTE.Size = new Size(409, 23);
            EMAILESTUDIANTE.TabIndex = 3;
            EMAILESTUDIANTE.Text = "CORREO ELECTRONICO";
            EMAILESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            EMAILESTUDIANTE.TextChanged += EMAILESTUDIANTE_TextChanged;
            // 
            // FACULTAD
            // 
            FACULTAD.ForeColor = SystemColors.InfoText;
            FACULTAD.FormattingEnabled = true;
            FACULTAD.ItemHeight = 15;
            FACULTAD.Location = new Point(270, 110);
            FACULTAD.Margin = new Padding(3, 2, 3, 2);
            FACULTAD.Name = "FACULTAD";
            FACULTAD.Size = new Size(180, 19);
            FACULTAD.TabIndex = 4;
            FACULTAD.SelectedIndexChanged += FACULTAD_SelectedIndexChanged;
            // 
            // INSTITUCION
            // 
            INSTITUCION.ForeColor = SystemColors.InfoText;
            INSTITUCION.FormattingEnabled = true;
            INSTITUCION.ItemHeight = 15;
            INSTITUCION.Location = new Point(156, 80);
            INSTITUCION.Margin = new Padding(3, 2, 3, 2);
            INSTITUCION.Name = "INSTITUCION";
            INSTITUCION.Size = new Size(407, 19);
            INSTITUCION.TabIndex = 5;
            INSTITUCION.SelectedIndexChanged += INSTITUCION_SelectedIndexChanged;
            // 
            // SECCIONESTUDIANTE
            // 
            SECCIONESTUDIANTE.ForeColor = SystemColors.InfoText;
            SECCIONESTUDIANTE.Location = new Point(156, 133);
            SECCIONESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            SECCIONESTUDIANTE.Name = "SECCIONESTUDIANTE";
            SECCIONESTUDIANTE.Size = new Size(71, 23);
            SECCIONESTUDIANTE.TabIndex = 6;
            SECCIONESTUDIANTE.Text = "SECCION";
            SECCIONESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            SECCIONESTUDIANTE.TextChanged += SECCIONESTUDIANTE_TextChanged;
            // 
            // CARRERA
            // 
            CARRERA.ForeColor = SystemColors.InfoText;
            CARRERA.FormattingEnabled = true;
            CARRERA.ItemHeight = 15;
            CARRERA.Location = new Point(232, 135);
            CARRERA.Margin = new Padding(3, 2, 3, 2);
            CARRERA.Name = "CARRERA";
            CARRERA.Size = new Size(220, 19);
            CARRERA.TabIndex = 7;
            CARRERA.SelectedIndexChanged += CARRERA_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.InfoText;
            textBox3.Location = new Point(455, 133);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "JORNADA";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // NACIMIENTOESTUDIANTE
            // 
            NACIMIENTOESTUDIANTE.ForeColor = SystemColors.InfoText;
            NACIMIENTOESTUDIANTE.Location = new Point(455, 110);
            NACIMIENTOESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            NACIMIENTOESTUDIANTE.Name = "NACIMIENTOESTUDIANTE";
            NACIMIENTOESTUDIANTE.Size = new Size(108, 23);
            NACIMIENTOESTUDIANTE.TabIndex = 9;
            NACIMIENTOESTUDIANTE.Text = "NACIMIENTO";
            NACIMIENTOESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            NACIMIENTOESTUDIANTE.TextChanged += NACIMIENTOESTUDIANTE_TextChanged;
            // 
            // SAVEBUTTON
            // 
            SAVEBUTTON.BackgroundImage = Properties.Resources.salvar;
            SAVEBUTTON.BackgroundImageLayout = ImageLayout.Zoom;
            SAVEBUTTON.ForeColor = SystemColors.ButtonHighlight;
            SAVEBUTTON.Location = new Point(301, 158);
            SAVEBUTTON.Margin = new Padding(3, 2, 3, 2);
            SAVEBUTTON.Name = "SAVEBUTTON";
            SAVEBUTTON.Size = new Size(70, 57);
            SAVEBUTTON.TabIndex = 10;
            SAVEBUTTON.UseVisualStyleBackColor = true;
            SAVEBUTTON.Click += SAVEBUTTON_Click;
            // 
            // crearestudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(592, 226);
            Controls.Add(SAVEBUTTON);
            Controls.Add(NACIMIENTOESTUDIANTE);
            Controls.Add(textBox3);
            Controls.Add(CARRERA);
            Controls.Add(SECCIONESTUDIANTE);
            Controls.Add(INSTITUCION);
            Controls.Add(FACULTAD);
            Controls.Add(EMAILESTUDIANTE);
            Controls.Add(telefonoalumno);
            Controls.Add(pictureBox1);
            Controls.Add(nombreestuadiante);
            Margin = new Padding(3, 2, 3, 2);
            Name = "crearestudiante";
            Text = "crearestudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreestuadiante;
        private PictureBox pictureBox1;
        private TextBox telefonoalumno;
        private TextBox EMAILESTUDIANTE;
        private ListBox FACULTAD;
        private ListBox INSTITUCION;
        private TextBox SECCIONESTUDIANTE;
        private ListBox CARRERA;
        private TextBox textBox3;
        private TextBox NACIMIENTOESTUDIANTE;
        private Button SAVEBUTTON;
    }
}