namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class actualizarcurso
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
            txtDescripcionCurso = new TextBox();
            cmbIDCurso = new ComboBox();
            txtNombreCurso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnActualizarDatos = new Button();
            SuspendLayout();
            // 
            // txtDescripcionCurso
            // 
            txtDescripcionCurso.Location = new Point(129, 105);
            txtDescripcionCurso.Name = "txtDescripcionCurso";
            txtDescripcionCurso.Size = new Size(147, 23);
            txtDescripcionCurso.TabIndex = 0;
            // 
            // cmbIDCurso
            // 
            cmbIDCurso.FormattingEnabled = true;
            cmbIDCurso.Location = new Point(129, 24);
            cmbIDCurso.Name = "cmbIDCurso";
            cmbIDCurso.Size = new Size(147, 23);
            cmbIDCurso.TabIndex = 1;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(129, 63);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(147, 23);
            txtNombreCurso.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccionar ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 66);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 108);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripción:";
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.BackColor = Color.Transparent;
            btnActualizarDatos.Location = new Point(64, 158);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(169, 43);
            btnActualizarDatos.TabIndex = 6;
            btnActualizarDatos.Text = "Actualizar Datos";
            btnActualizarDatos.UseVisualStyleBackColor = false;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // actualizarcurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 224);
            Controls.Add(btnActualizarDatos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreCurso);
            Controls.Add(cmbIDCurso);
            Controls.Add(txtDescripcionCurso);
            Name = "actualizarcurso";
            Text = "actualizarcurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcionCurso;
        private ComboBox cmbIDCurso;
        private TextBox txtNombreCurso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnActualizarDatos;
    }
}