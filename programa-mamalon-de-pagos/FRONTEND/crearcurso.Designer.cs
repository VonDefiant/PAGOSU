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
            txtIDCurso = new TextBox();
            txtNombreCurso = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvAgregar = new DataGridView();
            btnAgregarCurso = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).BeginInit();
            SuspendLayout();
            // 
            // txtIDCurso
            // 
            txtIDCurso.Location = new Point(122, 57);
            txtIDCurso.Name = "txtIDCurso";
            txtIDCurso.Size = new Size(301, 23);
            txtIDCurso.TabIndex = 0;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(122, 86);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(301, 23);
            txtNombreCurso.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(122, 115);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(301, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "ID_Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre del Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Descripción";
            // 
            // dgvAgregar
            // 
            dgvAgregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgregar.Location = new Point(12, 183);
            dgvAgregar.Name = "dgvAgregar";
            dgvAgregar.RowTemplate.Height = 25;
            dgvAgregar.Size = new Size(411, 290);
            dgvAgregar.TabIndex = 9;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = SystemColors.Menu;
            btnAgregarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCurso.ForeColor = Color.YellowGreen;
            btnAgregarCurso.Location = new Point(12, 154);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(411, 23);
            btnAgregarCurso.TabIndex = 11;
            btnAgregarCurso.Text = "Agregar";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 9);
            label4.Name = "label4";
            label4.Size = new Size(229, 30);
            label4.TabIndex = 12;
            label4.Text = "Diamante pa' Free fire";
            // 
            // crearcurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(434, 485);
            Controls.Add(label4);
            Controls.Add(btnAgregarCurso);
            Controls.Add(dgvAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreCurso);
            Controls.Add(txtIDCurso);
            Name = "crearcurso";
            Text = "crearcurso";
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDCurso;
        private TextBox txtNombreCurso;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvAgregar;
        private Button btnAgregarCurso;
        private Label label4;
    }
}