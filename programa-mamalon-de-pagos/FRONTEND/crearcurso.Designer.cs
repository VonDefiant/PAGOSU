namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearcurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearcurso));
            txtNombreCurso = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvAgregar = new DataGridView();
            btnAgregarCurso = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(14, 98);
            txtNombreCurso.Margin = new Padding(3, 4, 3, 4);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(470, 27);
            txtNombreCurso.TabIndex = 1;
            txtNombreCurso.TextChanged += txtNombreCurso_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(14, 153);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(470, 27);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 74);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre del Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Descripción";
            // 
            // dgvAgregar
            // 
            dgvAgregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgregar.Location = new Point(14, 244);
            dgvAgregar.Margin = new Padding(3, 4, 3, 4);
            dgvAgregar.Name = "dgvAgregar";
            dgvAgregar.RowHeadersWidth = 51;
            dgvAgregar.RowTemplate.Height = 25;
            dgvAgregar.Size = new Size(470, 387);
            dgvAgregar.TabIndex = 9;
            dgvAgregar.CellContentClick += dgvAgregar_CellContentClick;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = SystemColors.Menu;
            btnAgregarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCurso.ForeColor = Color.YellowGreen;
            btnAgregarCurso.Location = new Point(14, 205);
            btnAgregarCurso.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(470, 31);
            btnAgregarCurso.TabIndex = 11;
            btnAgregarCurso.Text = "Agregar";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(233, 24);
            label4.Name = "label4";
            label4.Size = new Size(107, 37);
            label4.TabIndex = 12;
            label4.Text = "CURSO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.cursos;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 70);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // crearcurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(496, 647);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnAgregarCurso);
            Controls.Add(dgvAgregar);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreCurso);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "crearcurso";
            Text = "crearcurso";
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombreCurso;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private DataGridView dgvAgregar;
        private Button btnAgregarCurso;
        private Label label4;
        private PictureBox pictureBox1;
    }
}