namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class Realizarpagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizarpagos));
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            PagosCB = new ComboBox();
            label3 = new Label();
            labelfecha = new Label();
            label4 = new Label();
            txtNumeroCuenta = new TextBox();
            labelNumeroCuenta = new Label();
            txtcarnet = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 176);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 31);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Pago";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Método de pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Cantidad a pagar:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(177, 134);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(210, 23);
            txtMonto.TabIndex = 5;
            // 
            // PagosCB
            // 
            PagosCB.FormattingEnabled = true;
            PagosCB.Items.AddRange(new object[] { "Tarjeta de crédito", "Tarjeta de dédito", "Transferencia" });
            PagosCB.Location = new Point(177, 60);
            PagosCB.Margin = new Padding(3, 2, 3, 2);
            PagosCB.Name = "PagosCB";
            PagosCB.Size = new Size(210, 23);
            PagosCB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 97);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 8;
            label3.Text = "Carnet de estudiante:";
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelfecha.Location = new Point(177, 43);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(178, 15);
            labelfecha.TabIndex = 11;
            labelfecha.Text = "Seleccione un metodo de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 26);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(560, 61);
            txtNumeroCuenta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(110, 23);
            txtNumeroCuenta.TabIndex = 13;
            txtNumeroCuenta.Visible = false;
            // 
            // labelNumeroCuenta
            // 
            labelNumeroCuenta.AutoSize = true;
            labelNumeroCuenta.Location = new Point(437, 63);
            labelNumeroCuenta.Name = "labelNumeroCuenta";
            labelNumeroCuenta.Size = new Size(109, 15);
            labelNumeroCuenta.TabIndex = 14;
            labelNumeroCuenta.Text = "Número de cuenta:";
            labelNumeroCuenta.Visible = false;
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(177, 97);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(210, 23);
            txtcarnet.TabIndex = 15;
            txtcarnet.TextChanged += txtcarnet_TextChanged_1;
            // 
            // Realizarpagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(850, 343);
            Controls.Add(txtcarnet);
            Controls.Add(labelNumeroCuenta);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label4);
            Controls.Add(labelfecha);
            Controls.Add(label3);
            Controls.Add(PagosCB);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Realizarpagos";
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
        private Label label3;
        private Label labelfecha;
        private Label label4;
        private TextBox txtNumeroCuenta;
        private Label labelNumeroCuenta;
        private TextBox txtcarnet;
    }
}