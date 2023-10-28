namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            PagosCB = new ComboBox();
            CarnetCB = new ComboBox();
            label3 = new Label();
            labelfecha = new Label();
            label4 = new Label();
            txtNumeroCuenta = new TextBox();
            labelNumeroCuenta = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(47, 235);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Pago";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Método de pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 182);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad a pagar:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(202, 179);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(239, 27);
            txtMonto.TabIndex = 5;
            // 
            // PagosCB
            // 
            PagosCB.FormattingEnabled = true;
            PagosCB.Items.AddRange(new object[] { "Tarjeta de crédito", "Tarjeta de dédito", "Transferencia" });
            PagosCB.Location = new Point(202, 80);
            PagosCB.Name = "PagosCB";
            PagosCB.Size = new Size(239, 28);
            PagosCB.TabIndex = 7;
            //PagosCB.SelectedIndexChanged += PagosCB_SelectedIndexChanged;
            // 
            // CarnetCB
            // 
            CarnetCB.FormattingEnabled = true;
            CarnetCB.Location = new Point(202, 129);
            CarnetCB.Name = "CarnetCB";
            CarnetCB.Size = new Size(239, 28);
            CarnetCB.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 129);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 8;
            label3.Text = "Carnet de estudiante:";
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelfecha.Location = new Point(47, 35);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(51, 20);
            labelfecha.TabIndex = 11;
            labelfecha.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 35);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 12;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(640, 81);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(125, 27);
            txtNumeroCuenta.TabIndex = 13;
            txtNumeroCuenta.Visible = false;
            //txtNumeroCuenta.TextChanged += txtNumeroCuenta_TextChanged;
            // 
            // labelNumeroCuenta
            // 
            labelNumeroCuenta.AutoSize = true;
            labelNumeroCuenta.Location = new Point(499, 84);
            labelNumeroCuenta.Name = "labelNumeroCuenta";
            labelNumeroCuenta.Size = new Size(135, 20);
            labelNumeroCuenta.TabIndex = 14;
            labelNumeroCuenta.Text = "Número de cuenta:";
            labelNumeroCuenta.Visible = false;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(971, 457);
            Controls.Add(labelNumeroCuenta);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label4);
            Controls.Add(labelfecha);
            Controls.Add(CarnetCB);
            Controls.Add(label3);
            Controls.Add(PagosCB);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pagos";
            Text = "Agregar Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private TextBox txtMonto;
        private ComboBox PagosCB;
        private ComboBox CarnetCB;
        private Label label3;
        private Label labelfecha;
        private Label label4;
        private TextBox txtNumeroCuenta;
        private Label labelNumeroCuenta;
    }
}