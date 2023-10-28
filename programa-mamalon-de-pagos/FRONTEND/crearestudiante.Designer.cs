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
            Cbcarrera = new ComboBox();
            CbFacultad = new ComboBox();
            Cbinstitucion = new ComboBox();
            cbjornada = new ComboBox();
            guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombreestuadiante
            // 
            nombreestuadiante.ForeColor = SystemColors.InfoText;
            nombreestuadiante.Location = new Point(156, 31);
            nombreestuadiante.Margin = new Padding(3, 2, 3, 2);
            nombreestuadiante.Name = "nombreestuadiante";
            nombreestuadiante.Size = new Size(409, 23);
            nombreestuadiante.TabIndex = 0;
            nombreestuadiante.TextAlign = HorizontalAlignment.Center;
            nombreestuadiante.TextChanged += nombreestuadiante_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alumno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(8, 31);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 220);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telefonoalumno
            // 
            telefonoalumno.ForeColor = SystemColors.InfoText;
            telefonoalumno.Location = new Point(154, 171);
            telefonoalumno.Margin = new Padding(3, 2, 3, 2);
            telefonoalumno.Name = "telefonoalumno";
            telefonoalumno.Size = new Size(110, 23);
            telefonoalumno.TabIndex = 2;
            telefonoalumno.TextAlign = HorizontalAlignment.Center;
            telefonoalumno.TextChanged += telefonoalumno_TextChanged;
            // 
            // EMAILESTUDIANTE
            // 
            EMAILESTUDIANTE.CharacterCasing = CharacterCasing.Upper;
            EMAILESTUDIANTE.ForeColor = SystemColors.InfoText;
            EMAILESTUDIANTE.Location = new Point(154, 75);
            EMAILESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            EMAILESTUDIANTE.Name = "EMAILESTUDIANTE";
            EMAILESTUDIANTE.Size = new Size(409, 23);
            EMAILESTUDIANTE.TabIndex = 3;
            EMAILESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            EMAILESTUDIANTE.TextChanged += EMAILESTUDIANTE_TextChanged;
            // 
            // SECCIONESTUDIANTE
            // 
            SECCIONESTUDIANTE.ForeColor = SystemColors.InfoText;
            SECCIONESTUDIANTE.Location = new Point(156, 219);
            SECCIONESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            SECCIONESTUDIANTE.Name = "SECCIONESTUDIANTE";
            SECCIONESTUDIANTE.Size = new Size(71, 23);
            SECCIONESTUDIANTE.TabIndex = 6;
            SECCIONESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            SECCIONESTUDIANTE.TextChanged += SECCIONESTUDIANTE_TextChanged;
            // 
            // NACIMIENTOESTUDIANTE
            // 
            NACIMIENTOESTUDIANTE.ForeColor = SystemColors.InfoText;
            NACIMIENTOESTUDIANTE.Location = new Point(453, 173);
            NACIMIENTOESTUDIANTE.Margin = new Padding(3, 2, 3, 2);
            NACIMIENTOESTUDIANTE.Name = "NACIMIENTOESTUDIANTE";
            NACIMIENTOESTUDIANTE.Size = new Size(108, 23);
            NACIMIENTOESTUDIANTE.TabIndex = 9;
            NACIMIENTOESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            NACIMIENTOESTUDIANTE.TextChanged += NACIMIENTOESTUDIANTE_TextChanged;
            // 
            // Cbcarrera
            // 
            Cbcarrera.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cbcarrera.FormattingEnabled = true;
            Cbcarrera.Location = new Point(232, 218);
            Cbcarrera.Margin = new Padding(3, 2, 3, 2);
            Cbcarrera.Name = "Cbcarrera";
            Cbcarrera.Size = new Size(218, 23);
            Cbcarrera.TabIndex = 11;
            Cbcarrera.SelectedIndexChanged += Cbcarrera_SelectedIndexChanged;
            // 
            // CbFacultad
            // 
            CbFacultad.FormattingEnabled = true;
            CbFacultad.Location = new Point(268, 170);
            CbFacultad.Margin = new Padding(3, 2, 3, 2);
            CbFacultad.Name = "CbFacultad";
            CbFacultad.Size = new Size(180, 23);
            CbFacultad.TabIndex = 12;
            CbFacultad.SelectedIndexChanged += CbFacultad_SelectedIndexChanged;
            // 
            // Cbinstitucion
            // 
            Cbinstitucion.FormattingEnabled = true;
            Cbinstitucion.Location = new Point(154, 121);
            Cbinstitucion.Margin = new Padding(3, 2, 3, 2);
            Cbinstitucion.Name = "Cbinstitucion";
            Cbinstitucion.Size = new Size(409, 23);
            Cbinstitucion.TabIndex = 13;
            Cbinstitucion.SelectedIndexChanged += Cbinstitucion_SelectedIndexChanged;
            // 
            // cbjornada
            // 
            cbjornada.FormattingEnabled = true;
            cbjornada.Location = new Point(455, 219);
            cbjornada.Margin = new Padding(3, 2, 3, 2);
            cbjornada.Name = "cbjornada";
            cbjornada.Size = new Size(108, 23);
            cbjornada.TabIndex = 14;
            cbjornada.SelectedIndexChanged += cbjornada_SelectedIndexChanged;
            // 
            // guardar
            // 
            guardar.BackgroundImage = Properties.Resources.salvar;
            guardar.BackgroundImageLayout = ImageLayout.Zoom;
            guardar.Location = new Point(293, 246);
            guardar.Name = "guardar";
            guardar.Size = new Size(75, 55);
            guardar.TabIndex = 15;
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 19);
            label1.TabIndex = 16;
            label1.Text = "NOMBRE COMPLETO DEL ESTUDIANTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(232, 54);
            label2.Name = "label2";
            label2.Size = new Size(277, 19);
            label2.TabIndex = 17;
            label2.Text = "CORREO ELECTRONICO DEL ESTUDIANTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(248, 100);
            label3.Name = "label3";
            label3.Size = new Size(202, 19);
            label3.TabIndex = 18;
            label3.Text = "SELECCIONE LA INSTITUCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(167, 150);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 19;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(266, 150);
            label5.Name = "label5";
            label5.Size = new Size(182, 19);
            label5.TabIndex = 20;
            label5.Text = "SELECCIONE LA FACULTAD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(455, 150);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 21;
            label6.Text = "NACIMIENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(156, 197);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 22;
            label7.Text = "SECCION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(248, 197);
            label8.Name = "label8";
            label8.Size = new Size(177, 19);
            label8.TabIndex = 23;
            label8.Text = "SELECCIONE LA CARRERA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(465, 198);
            label9.Name = "label9";
            label9.Size = new Size(76, 19);
            label9.TabIndex = 24;
            label9.Text = "JORNADA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(292, 304);
            label10.Name = "label10";
            label10.Size = new Size(77, 19);
            label10.TabIndex = 25;
            label10.Text = "GUARDAR";
            // 
            // crearestudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(611, 326);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guardar);
            Controls.Add(cbjornada);
            Controls.Add(Cbinstitucion);
            Controls.Add(CbFacultad);
            Controls.Add(Cbcarrera);
            Controls.Add(NACIMIENTOESTUDIANTE);
            Controls.Add(SECCIONESTUDIANTE);
            Controls.Add(EMAILESTUDIANTE);
            Controls.Add(telefonoalumno);
            Controls.Add(pictureBox1);
            Controls.Add(nombreestuadiante);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox Cbcarrera;
        private ComboBox CbFacultad;
        private ComboBox Cbinstitucion;
        private ComboBox cbjornada;
        private Button guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}