namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class consultaaumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaaumno));
            CARNECONSULTA = new TextBox();
            dataGridView3 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buscarboton = new Button();
            label10 = new Label();
            TXTNOMBRECOMPLETO = new TextBox();
            txtelefono = new TextBox();
            txtcorreo = new TextBox();
            textseccion = new TextBox();
            cmfacultad = new ComboBox();
            cminstitucion = new TextBox();
            txtcarreta = new TextBox();
            chbcursos = new CheckedListBox();
            BtnActualizar = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // CARNECONSULTA
            // 
            CARNECONSULTA.Location = new Point(29, 30);
            CARNECONSULTA.Name = "CARNECONSULTA";
            CARNECONSULTA.Size = new Size(98, 23);
            CARNECONSULTA.TabIndex = 0;
            CARNECONSULTA.Text = "Ingrese Carné";
            CARNECONSULTA.TextAlign = HorizontalAlignment.Center;
            CARNECONSULTA.TextChanged += CARNECONSULTA_TextChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(156, 119);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(59, 22);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 4;
            label1.Text = "NOMBRE COMPLETO DEL ESTUDIANTE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "TELEFONO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 99);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "JORNADA";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 56);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 8;
            label4.Text = "CARRERA ASIGNADA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 99);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 10;
            label5.Text = "FACULTAD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 99);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "SECCION";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 201);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 14;
            label7.Text = "CURSOS ASIGNADOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 101);
            label8.Name = "label8";
            label8.Size = new Size(160, 15);
            label8.TabIndex = 16;
            label8.Text = "INSTITUCIÓN EN LA ESTUDIA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 149);
            label9.Name = "label9";
            label9.Size = new Size(140, 15);
            label9.TabIndex = 18;
            label9.Text = "CORREO INSTITUCIONAL";
            // 
            // buscarboton
            // 
            buscarboton.BackColor = Color.Wheat;
            buscarboton.BackgroundImage = Properties.Resources.informacion;
            buscarboton.BackgroundImageLayout = ImageLayout.Zoom;
            buscarboton.Location = new Point(79, 409);
            buscarboton.Name = "buscarboton";
            buscarboton.Size = new Size(92, 59);
            buscarboton.TabIndex = 19;
            buscarboton.UseVisualStyleBackColor = false;
            buscarboton.Click += buscarboton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 469);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 20;
            label10.Text = "BUSCAR";
            // 
            // TXTNOMBRECOMPLETO
            // 
            TXTNOMBRECOMPLETO.Location = new Point(134, 30);
            TXTNOMBRECOMPLETO.Name = "TXTNOMBRECOMPLETO";
            TXTNOMBRECOMPLETO.Size = new Size(348, 23);
            TXTNOMBRECOMPLETO.TabIndex = 21;
            TXTNOMBRECOMPLETO.TextChanged += TXTNOMBRECOMPLETO_TextChanged;
            // 
            // txtelefono
            // 
            txtelefono.Location = new Point(31, 73);
            txtelefono.Name = "txtelefono";
            txtelefono.Size = new Size(119, 23);
            txtelefono.TabIndex = 22;
            txtelefono.TextChanged += txtelefono_TextChanged;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(29, 167);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(452, 23);
            txtcorreo.TabIndex = 23;
            txtcorreo.TextChanged += txtcorreo_TextChanged;
            // 
            // textseccion
            // 
            textseccion.Location = new Point(221, 119);
            textseccion.Name = "textseccion";
            textseccion.Size = new Size(56, 23);
            textseccion.TabIndex = 24;
            textseccion.TextChanged += textseccion_TextChanged;
            // 
            // cmfacultad
            // 
            cmfacultad.FormattingEnabled = true;
            cmfacultad.Location = new Point(29, 117);
            cmfacultad.Name = "cmfacultad";
            cmfacultad.Size = new Size(121, 23);
            cmfacultad.TabIndex = 25;
            cmfacultad.SelectedIndexChanged += cmfacultad_SelectedIndexChanged;
            // 
            // cminstitucion
            // 
            cminstitucion.Location = new Point(283, 119);
            cminstitucion.Name = "cminstitucion";
            cminstitucion.Size = new Size(198, 23);
            cminstitucion.TabIndex = 26;
            cminstitucion.TextChanged += cminstitucion_TextChanged;
            // 
            // txtcarreta
            // 
            txtcarreta.Location = new Point(153, 73);
            txtcarreta.Name = "txtcarreta";
            txtcarreta.Size = new Size(328, 23);
            txtcarreta.TabIndex = 27;
            txtcarreta.TextChanged += txtcarreta_TextChanged;
            // 
            // chbcursos
            // 
            chbcursos.FormattingEnabled = true;
            chbcursos.Location = new Point(12, 219);
            chbcursos.Name = "chbcursos";
            chbcursos.Size = new Size(501, 184);
            chbcursos.TabIndex = 28;
            chbcursos.SelectedIndexChanged += chbcursos_SelectedIndexChanged;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(271, 409);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(74, 59);
            BtnActualizar.TabIndex = 29;
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(271, 471);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 30;
            label11.Text = "ACTUALIZAR";
            // 
            // consultaaumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(525, 500);
            Controls.Add(label11);
            Controls.Add(BtnActualizar);
            Controls.Add(chbcursos);
            Controls.Add(txtcarreta);
            Controls.Add(cminstitucion);
            Controls.Add(cmfacultad);
            Controls.Add(textseccion);
            Controls.Add(txtcorreo);
            Controls.Add(txtelefono);
            Controls.Add(TXTNOMBRECOMPLETO);
            Controls.Add(label10);
            Controls.Add(buscarboton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(CARNECONSULTA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "consultaaumno";
            Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CARNECONSULTA;
        private DataGridView dataGridView3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buscarboton;
        private Label label10;
        private TextBox TXTNOMBRECOMPLETO;
        private TextBox txtelefono;
        private TextBox txtcorreo;
        private TextBox textseccion;
        private ComboBox cmfacultad;
        private TextBox cminstitucion;
        private TextBox txtcarreta;
        private CheckedListBox chbcursos;
        private Button BtnActualizar;
        private Label label11;
    }
}