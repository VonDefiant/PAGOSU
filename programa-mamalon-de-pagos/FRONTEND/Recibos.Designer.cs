namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class Recibos
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
            btnBuscar = new Button();
            txtBuscarPorCarnet = new TextBox();
            dtpBuscarPorFecha = new DateTimePicker();
            txtBuscarPorNumeroRecibo = new TextBox();
            labelBuscarCarnet = new Label();
            labelBuscarRecibo = new Label();
            labelBuscarFecha = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(43, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.VisibleChanged += btnAceptar_Click;
            // 
            // txtBuscarPorCarnet
            // 
            txtBuscarPorCarnet.Location = new Point(274, 42);
            txtBuscarPorCarnet.Name = "txtBuscarPorCarnet";
            txtBuscarPorCarnet.Size = new Size(177, 27);
            txtBuscarPorCarnet.TabIndex = 1;
            txtBuscarPorCarnet.Visible = false;
            txtBuscarPorCarnet.VisibleChanged += btnAceptar_Click;
            // 
            // dtpBuscarPorFecha
            // 
            dtpBuscarPorFecha.Location = new Point(502, 42);
            dtpBuscarPorFecha.Name = "dtpBuscarPorFecha";
            dtpBuscarPorFecha.Size = new Size(287, 27);
            dtpBuscarPorFecha.TabIndex = 2;
            dtpBuscarPorFecha.Visible = false;
            dtpBuscarPorFecha.VisibleChanged += btnAceptar_Click;
            // 
            // txtBuscarPorNumeroRecibo
            // 
            txtBuscarPorNumeroRecibo.Location = new Point(43, 44);
            txtBuscarPorNumeroRecibo.Name = "txtBuscarPorNumeroRecibo";
            txtBuscarPorNumeroRecibo.Size = new Size(176, 27);
            txtBuscarPorNumeroRecibo.TabIndex = 3;
            txtBuscarPorNumeroRecibo.Visible = false;
            txtBuscarPorNumeroRecibo.VisibleChanged += btnAceptar_Click;
            // 
            // labelBuscarCarnet
            // 
            labelBuscarCarnet.AutoSize = true;
            labelBuscarCarnet.Location = new Point(280, 19);
            labelBuscarCarnet.Name = "labelBuscarCarnet";
            labelBuscarCarnet.Size = new Size(171, 20);
            labelBuscarCarnet.TabIndex = 4;
            labelBuscarCarnet.Text = "Ingrese el No. De carnet:";
            labelBuscarCarnet.Visible = false;
            // 
            // labelBuscarRecibo
            // 
            labelBuscarRecibo.AutoSize = true;
            labelBuscarRecibo.Location = new Point(43, 19);
            labelBuscarRecibo.Name = "labelBuscarRecibo";
            labelBuscarRecibo.Size = new Size(176, 20);
            labelBuscarRecibo.TabIndex = 6;
            labelBuscarRecibo.Text = "Ingrese el  No. De recibo:";
            labelBuscarRecibo.Visible = false;
            // 
            // labelBuscarFecha
            // 
            labelBuscarFecha.AutoSize = true;
            labelBuscarFecha.Location = new Point(592, 19);
            labelBuscarFecha.Name = "labelBuscarFecha";
            labelBuscarFecha.Size = new Size(116, 20);
            labelBuscarFecha.TabIndex = 7;
            labelBuscarFecha.Text = "Ingrese la fecha:";
            labelBuscarFecha.Visible = false;
            // 
            // Recibos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1456, 693);
            Controls.Add(labelBuscarFecha);
            Controls.Add(labelBuscarRecibo);
            Controls.Add(labelBuscarCarnet);
            Controls.Add(txtBuscarPorNumeroRecibo);
            Controls.Add(dtpBuscarPorFecha);
            Controls.Add(txtBuscarPorCarnet);
            Controls.Add(btnBuscar);
            Name = "Recibos";
            Text = "Recibos";
            Load += Recibos_Load;
            VisibleChanged += SeleccionarBusquedaCB_SelectedIndexChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBuscarPorCarnet;
        private DateTimePicker dtpBuscarPorFecha;
        private TextBox txtBuscarPorNumeroRecibo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAceptar;
        private Label labelBuscarCarnet;
        private Label labelBuscarFecha;
        private Label labelBuscarRecibo;
        private ComboBox SeleccionarBusquedaCB;
    }
}