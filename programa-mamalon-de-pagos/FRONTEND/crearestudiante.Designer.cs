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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearestudiante));
            nombreestuadiante = new TextBox();
            pictureBox1 = new PictureBox();
            telefonoalumno = new TextBox();
            EMAILESTUDIANTE = new TextBox();
            SECCIONESTUDIANTE = new TextBox();
            NACIMIENTOESTUDIANTE = new TextBox();
            SAVEBUTTON = new Button();
            Cbcarrera = new ComboBox();
            CbFacultad = new ComboBox();
            Cbinstitucion = new ComboBox();
            cbjornada = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombreestuadiante
            // 
            nombreestuadiante.ForeColor = SystemColors.InfoText;
            nombreestuadiante.Location = new Point(176, 41);
            nombreestuadiante.Name = "nombreestuadiante";
            nombreestuadiante.Size = new Size(467, 27);
            nombreestuadiante.TabIndex = 0;
            nombreestuadiante.Text = "INGRESE EL NOMBRE COMPLETO";
            nombreestuadiante.TextAlign = HorizontalAlignment.Center;
            nombreestuadiante.TextChanged += nombreestuadiante_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alumno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 163);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telefonoalumno
            // 
            telefonoalumno.ForeColor = SystemColors.InfoText;
            telefonoalumno.Location = new Point(178, 144);
            telefonoalumno.Name = "telefonoalumno";
            telefonoalumno.Size = new Size(125, 27);
            telefonoalumno.TabIndex = 2;
            telefonoalumno.Text = "TELEFONO";
            telefonoalumno.TextAlign = HorizontalAlignment.Center;
            telefonoalumno.TextChanged += telefonoalumno_TextChanged;
            // 
            // EMAILESTUDIANTE
            // 
            EMAILESTUDIANTE.ForeColor = SystemColors.InfoText;
            EMAILESTUDIANTE.Location = new Point(176, 75);
            EMAILESTUDIANTE.Name = "EMAILESTUDIANTE";
            EMAILESTUDIANTE.Size = new Size(467, 27);
            EMAILESTUDIANTE.TabIndex = 3;
            EMAILESTUDIANTE.Text = "CORREO ELECTRONICO";
            EMAILESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            EMAILESTUDIANTE.TextChanged += EMAILESTUDIANTE_TextChanged;
            // 
            // SECCIONESTUDIANTE
            // 
            SECCIONESTUDIANTE.ForeColor = SystemColors.InfoText;
            SECCIONESTUDIANTE.Location = new Point(178, 177);
            SECCIONESTUDIANTE.Name = "SECCIONESTUDIANTE";
            SECCIONESTUDIANTE.Size = new Size(81, 27);
            SECCIONESTUDIANTE.TabIndex = 6;
            SECCIONESTUDIANTE.Text = "SECCION";
            SECCIONESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            SECCIONESTUDIANTE.TextChanged += SECCIONESTUDIANTE_TextChanged;
            // 
            // NACIMIENTOESTUDIANTE
            // 
            NACIMIENTOESTUDIANTE.ForeColor = SystemColors.InfoText;
            NACIMIENTOESTUDIANTE.Location = new Point(520, 147);
            NACIMIENTOESTUDIANTE.Name = "NACIMIENTOESTUDIANTE";
            NACIMIENTOESTUDIANTE.Size = new Size(123, 27);
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
            SAVEBUTTON.Location = new Point(344, 211);
            SAVEBUTTON.Name = "SAVEBUTTON";
            SAVEBUTTON.Size = new Size(80, 76);
            SAVEBUTTON.TabIndex = 10;
            SAVEBUTTON.UseVisualStyleBackColor = true;
            SAVEBUTTON.Click += SAVEBUTTON_Click;
            // 
            // Cbcarrera
            // 
            Cbcarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cbcarrera.FormattingEnabled = true;
            Cbcarrera.Location = new Point(265, 176);
            Cbcarrera.Name = "Cbcarrera";
            Cbcarrera.Size = new Size(249, 28);
            Cbcarrera.TabIndex = 11;
            Cbcarrera.Text = "CARRERA";
            // 
            // CbFacultad
            // 
            CbFacultad.FormattingEnabled = true;
            CbFacultad.Location = new Point(309, 143);
            CbFacultad.Name = "CbFacultad";
            CbFacultad.Size = new Size(205, 28);
            CbFacultad.TabIndex = 12;
            CbFacultad.Text = "FACULTAD";
            CbFacultad.SelectedIndexChanged += CbFacultad_SelectedIndexChanged;
            // 
            // Cbinstitucion
            // 
            Cbinstitucion.FormattingEnabled = true;
            Cbinstitucion.Location = new Point(178, 108);
            Cbinstitucion.Name = "Cbinstitucion";
            Cbinstitucion.Size = new Size(467, 28);
            Cbinstitucion.TabIndex = 13;
            Cbinstitucion.Text = "INTITUCION";
            Cbinstitucion.SelectedIndexChanged += Cbinstitucion_SelectedIndexChanged;
            // 
            // cbjornada
            // 
            cbjornada.FormattingEnabled = true;
            cbjornada.Location = new Point(520, 177);
            cbjornada.Name = "cbjornada";
            cbjornada.Size = new Size(123, 28);
            cbjornada.TabIndex = 14;
            cbjornada.Text = "JORNADA";
            cbjornada.SelectedIndexChanged += cbjornada_SelectedIndexChanged;
            // 
            // crearestudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(677, 301);
            Controls.Add(cbjornada);
            Controls.Add(Cbinstitucion);
            Controls.Add(CbFacultad);
            Controls.Add(Cbcarrera);
            Controls.Add(SAVEBUTTON);
            Controls.Add(NACIMIENTOESTUDIANTE);
            Controls.Add(SECCIONESTUDIANTE);
            Controls.Add(EMAILESTUDIANTE);
            Controls.Add(telefonoalumno);
            Controls.Add(pictureBox1);
            Controls.Add(nombreestuadiante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearestudiante";
            Text = "crearestudiante";
            Load += crearestudiante_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreestuadiante;
        private PictureBox pictureBox1;
        private TextBox telefonoalumno;
        private TextBox EMAILESTUDIANTE;
        private TextBox SECCIONESTUDIANTE;
        private TextBox NACIMIENTOESTUDIANTE;
        private Button SAVEBUTTON;
        private ComboBox Cbcarrera;
        private ComboBox CbFacultad;
        private ComboBox Cbinstitucion;
        private ComboBox cbjornada;
    }
}